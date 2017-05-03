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
    /// Логика взаимодействия для listBoxWindow.xaml
    /// </summary>
    public partial class listBoxWindow : Window
    {
        public listBoxWindow()
        {
            InitializeComponent();
            string ConnectionString = @"Data Source=SERGEY-PC;Initial Catalog=Kvadro;Integrated Security=True";
            System.Diagnostics.Stopwatch sw2 = System.Diagnostics.Stopwatch.StartNew();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com = new SqlCommand("SELECT * FROM EmployeeInfo", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            int nrec = 0;
            while (reader.HasRows)
            {

                reader.Read();
                l1.Items.Add(
                    reader.GetSqlInt64(0).ToString()
                 + "     " + reader.GetSqlString(1).ToString()
                 + "     " + reader.GetSqlString(2).ToString()
                 + "     " + reader.GetSqlString(3).ToString()
                 + "     " + reader.GetSqlInt32(4).ToString()
                 + "     " + reader.GetSqlDateTime(5).ToString()
                 + "     " + reader.GetSqlString(6).ToString()
                 + "     " + reader.GetSqlString(7).ToString()
                 + "     " + reader.GetSqlString(8).ToString()
                 + "     " + reader.GetSqlInt32(9).ToString()
                 + "     " + reader.GetSqlInt64(10).ToString());



                nrec++;


            }
            reader.Close();
            con.Close();
            long elapsed = sw2.ElapsedMilliseconds;
        }
    }
}
