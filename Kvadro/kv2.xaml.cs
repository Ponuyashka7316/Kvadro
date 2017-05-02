using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;

using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data;


namespace Kvadro
{
    /// <summary>
    /// Логика взаимодействия для kv2.xaml
    /// </summary>
    public partial class kv2 : Window
    {
        
        KvadroEntities6 db;
        public kv2()
        {
            InitializeComponent();
            //DataContext = this;

            //ObjectQuery<ProjectInfo> products = db.ProjectInfos;

            //var query =
            //from product in products
            //select new { product.Name, product.Color, CategoryName = product.ProductCategory.Name, product.ListPrice };
            //kvadroGrid.ItemsSource = query.ToList();

            // kvadroGrid.ItemsSource = db.ProjectInfos.Local.ToList();
            //this.Closing += MyWindow_Closing;
            //db.ProjectInfos.Load();
            db = new KvadroEntities6();
            var data = from r in db.ProjectInfo select r;
            kvadroGrid.ItemsSource = data.ToList();

            var ConnectionString = @"Data Source=SERGEY-PC;Initial Catalog=Kvadro;Integrated Security=True";
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM CustomerInfo", con);
                con.Open();
                SqlDataReader reader;
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        string result = reader.GetString(4);
                        ComboINN.Items.Add(result);
                        ComboINN.Text = result;
                        
                    }
                    catch { }

                }
                con.Close();
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            long pr_id = (kvadroGrid.SelectedItem as ProjectInfo).ProjectID;
            ProjectInfo pr = (from r in db.ProjectInfo where r.ProjectID == pr_id select r).SingleOrDefault();
            db.ProjectInfo.Remove(pr);
            db.SaveChanges();
            kvadroGrid.ItemsSource = db.ProjectInfo.ToList();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MyWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void DataGridTextColumn_PastingCellClipboardContent(object sender, DataGridCellClipboardEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ProjectInfo prj = new ProjectInfo();
            try
            {
                prj.ProjectID = Convert.ToInt32(id.Text);
                prj.ProjectName = name.Text;
                prj.ProjectStart = Convert.ToDateTime(start.Text);
                prj.ProjectStop = Convert.ToDateTime(stop.Text);
                prj.Chief = chief.Text;
                prj.Cost = Convert.ToDecimal(cost.Text);
                prj.INN = ComboINN.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input: "+ex.Message);
            }
            db.ProjectInfo.Add(prj);
            db.SaveChanges();
            kvadroGrid.ItemsSource = db.ProjectInfo.ToList();
        }

        private void kvadroGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            //id.Text = DataGridCellInfo.
        }
    }
}
