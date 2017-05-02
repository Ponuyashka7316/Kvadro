using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Kvadro
{
    /// <summary>
    /// Логика взаимодействия для kv3.xaml
    /// </summary>
    public partial class kv3 : Window
    {
        KvadroEntities6 db;
        public kv3()
        {
            InitializeComponent();
            db = new KvadroEntities6();
            var data = from r in db.CustomerInfo select r;
            kvadroGrid.ItemsSource = data.ToList();
            //var ConnectionString = @"Data Source=SERGEY-PC;Initial Catalog=Kvadro;Integrated Security=True";

            //using (SqlConnection con = new SqlConnection(ConnectionString))
            //{
            //    SqlCommand com = new SqlCommand("SELECT * FROM CustomerInfo", con);
            //    con.Open();
            //    SqlDataReader reader;
            //    reader = com.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        try
            //        {
            //            string result = reader.GetString(4);
            //            ComboINN.Items.Add(result);
            //            ComboINN.Text = result;

            //        }
            //        catch { }

            //    }
            //    con.Close();
            //}
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
            string pr_id = (kvadroGrid.SelectedItem as CustomerInfo).INN;
            CustomerInfo pr = (from r in db.CustomerInfo where r.INN == pr_id select r).SingleOrDefault();
            db.CustomerInfo.Remove(pr);
            db.SaveChanges();
            kvadroGrid.ItemsSource = db.CustomerInfo.ToList();

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
            CustomerInfo c = new CustomerInfo();
            try
            {
                c.Customer = name1.Text;
                c.PhoneWorker = Int32.Parse(Phone.Text) ;
                c.Bank = bank.Text;
                c.Account = acc.Text;
                c.AdressCost = adress.Text;
                c.FioWorker = fio.Text;
                c.Phone = phone.Text;
                c.INN = iin.Text;
                // prj.INN = inn.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input: " + ex.Message);
            }
            db.CustomerInfo.Add(c);
            db.SaveChanges();
            kvadroGrid.ItemsSource = db.CustomerInfo.ToList();
        }

        private void kvadroGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            //id.Text = DataGridCellInfo.
        }
    }
}
