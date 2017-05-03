using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Kvadro
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class InfoProjectsAndWorkers
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Year { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmployeeStart { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStart { get; set; }
        public string Chief { get; set; }

    }

    
    public partial class MainWindow : Window
    {
        
        private static KvadroDataBaseDataContext db = new KvadroDataBaseDataContext();
        bool isWiden = false;
        public MainWindow()
        {
            InitializeComponent();
            //Par_Types_Cmb.Items.Add("Parallel output");
            //Par_Types_Cmb.Items.Add("Standart output");
            //Par_Types_Cmb.Items.Add("Parallel with order output");
        }
        public static string ProcessItem(InfoProjectsAndWorkers item)
        {
            Thread.Sleep(5);
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            return string.Format(culture, "|ID:{0, -15} |Name:{1, -35} |Year:{2, -15} |Salary:{3, -15} |EmpStart:{4, -13} |ProjectName:{5, -25} |ProjectStart:{6, -13} |Chief:{7, -20}|",
                item.EmployeeID,
                item.EmployeeName,
                item.Year.ToString("dd.MM.yyyy"),
                item.Salary,
                item.EmployeeStart.ToString("dd.MM.yyyy"),
                item.ProjectName,
                item.ProjectStart.ToString("dd.MM.yyyy"),
                item.Chief);
        }

        

        public static IEnumerable<InfoProjectsAndWorkers> InfoAboutProjectsAndWorkers()
        {
            var s = from e in db.EmployeeInfo
                    join pi in db.ProjectInfo

                     on e.ProjectID equals pi.ProjectID
                    select new InfoProjectsAndWorkers()
                    {
                        EmployeeID = e.EmployeeID,
                        EmployeeName = e.EmployeeName,
                        Year = e.Year,
                        Salary = e.SalaryInfo.Salary,
                        EmployeeStart = (DateTime)e.Participation_in_project.StartDate,
                        ProjectName = pi.ProjectName,
                        ProjectStart = (DateTime)pi.ProjectStart,
                        Chief = pi.Chief

                    };

            return s;
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isWiden = true;
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isWiden = false;
            Rectangle rect = (Rectangle)sender;
            rect.ReleaseMouseCapture();
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            if (isWiden)
            {
                rect.CaptureMouse();
                double newWidth = e.GetPosition(this).X + 5;
                //cmdClose
                if (newWidth > 0) this.Width = newWidth;
            }
        }

        private void TextBlock_Drop(object sender, DragEventArgs e)
        {

        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public int NonParallel(IEnumerable<InfoProjectsAndWorkers> sl)
        {
            int count = 1;
            var info = from s in sl
                       select ProcessItem(s);
            foreach (var item in info)
            {
                if (TypeChoose.SelectedValue.ToString() == "textBox")
                {
                    TextOut.Text += Frame((string)item) + "\n" + item + "\n";
                }
                if (TypeChoose.SelectedValue.ToString() == "listBox")
                {
                    ListOut.Items.Add(Frame((string)item) + "\n" + item + "\n");
                }
                //Console.WriteLine(Frame(item));
                //Console.WriteLine(item);
                count++;
            }
            return count;
        }
        public int Parallel(IEnumerable<InfoProjectsAndWorkers> sl)
        {
            int count = 1;
            var info = from s in sl.AsParallel()
                       select ProcessItem(s);
            return Each(count, info);
        }
        public int ParallelOrdered(IEnumerable<InfoProjectsAndWorkers> sl)
        {
            int count = 1;
            var query = from s in sl.AsParallel().AsOrdered()
                        select ProcessItem(s);
            return Each(count, query);
        }
        public int Each(int count, System.Linq.ParallelQuery info)
        {
            if (TypeChoose.SelectedValue.ToString() == "textBox")
            {
                foreach (var item in info)
                {
                    TextOut.Text += Frame((string)item) + "\n" + item + "\n";
                    //Console.WriteLine(Frame((string)item));
                    //Console.WriteLine(item);
                    count++;
                }
            }
            if (TypeChoose.SelectedValue.ToString() == "listBox")
            {
                foreach (var item in info)
                {
                    ListOut.Items.Add(
                        Frame((string)item) + "\n" + item + "\n"
                        );
                    //Console.WriteLine(Frame((string)item));
                    //Console.WriteLine(item);
                    count++;
                }
            }
            return count;
        }

        static public string Frame(string val)
        {
            var bar = "";
            int valLen = val.Length;
            for (int i = 0; i < valLen; i++)
                bar += "-";
            return bar;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            IEnumerable<InfoProjectsAndWorkers> sl = InfoAboutProjectsAndWorkers();
            var count = 0;
            switch (Par_Types_Cmb.SelectedValue.ToString())
            {
                case "Parallel output": count = Parallel(sl); break;
                case "Standart output": count = NonParallel(sl); break;
                case "Parallel with order output": count = ParallelOrdered(sl); break;
                    //default:  count = NonParallel(sl); break;
            }
            long elapsed = sw.ElapsedMilliseconds;
            if (TypeChoose.SelectedValue.ToString() == "textBox")
                Timer1.Text = elapsed.ToString();
            if (TypeChoose.SelectedValue.ToString() == "listBox")
                Timer2.Text = elapsed.ToString();
            Count.Text = count.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextOut.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListOut.Items.Clear();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            kv2 f = new kv2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            kv3 f = new kv3();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //private void Button1_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Kv3 f = new Kv3();
        //    this.Hide();
        //    f.ShowDialog();
        //    this.Show();
        //}
    }
}
