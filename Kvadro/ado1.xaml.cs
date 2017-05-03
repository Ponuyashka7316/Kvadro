using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Kvadro
{
    /// <summary>
    /// Логика взаимодействия для ado1.xaml
    /// </summary>
    public partial class ado1 : Window
    {
        string ConnectionString = @"Data Source=SERGEY-PC;Initial Catalog=Kvadro;Integrated Security=True";
        public ado1()
        {
            InitializeComponent();
            
            Initializedb(ConnectionString);
        }
        SqlDataAdapter da;
        DataSet ds;
        DataTable emptable;
        public void Initializedb(string ConnectionString)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            emptable = new DataTable();
            da = new SqlDataAdapter(@"SELECT * FROM EmployeeInfo ", con);
            ds = new DataSet();
            da.Fill(ds, "EmployeeInfo");
            kvadroGrid.ItemsSource = ds.Tables["EmployeeInfo"].DefaultView;
            con.Close();
        }

        private void MyWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void kvadroGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }
        public void Update()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(da);
            da.Update(ds.Tables["EmployeeInfo"]);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //update bd

            Update();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (kvadroGrid.SelectedItems != null)
            {
                for (int i = 0; i < kvadroGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = kvadroGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            Update();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                emptable = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT EmployeeInfo (EmployeeID, EmployeeName, Adress, District, Experiance, Year, " +
                    "Language, Base, Comment, BonusAll, ProjectID) VALUES ("+EmpID.Text+", "+
                    Name.Text + ", " +
                    adress.Text + ", " +
                    district.Text + ", " +
                    exp.Text + ", " +
                    year.Text + ", " +
                    lang.Text + ", " +
                    Base.Text + ", " +
                    comment.Text + ", " +
                    BonusAll.Text + ", " +
                    ProjID.Text+")";
                cmd.Connection = con;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //da = new SqlDataAdapter(@"INSERT INTO EmployeeInfo values "+EmpID.Text+", "+
                //    Name.Text+ ", "+
                //    adress.Text + ", " +
                //    district.Text + ", " +
                //    exp.Text + ", " +
                //    year.Text + ", " +
                //    lang.Text + ", " +
                //    Base.Text + ", " +
                //    comment.Text + ", " +
                //    BonusAll.Text + ", " +
                //    ProjID.Text+"", con);
                //ds = new DataSet();
                //da.Fill(ds, "EmployeeInfo");
                //kvadroGrid.ItemsSource = ds.Tables["EmployeeInfo"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            Update();
        }

        private void DataGridTextColumn_PastingCellClipboardContent(object sender, DataGridCellClipboardEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
           textBoxWindow w = new textBoxWindow();

            w.ShowDialog();
           
           


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBoxWindow t = new textBoxWindow();
            
            this.Hide();
            t.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var xml = XDocument.Load("c:\\Somewhere\\Books.xml").Root;
            kvadroGrid.DataContext = xml;
        }

       
    }
}
