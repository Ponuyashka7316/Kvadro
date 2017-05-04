﻿using System;
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
    /// Логика взаимодействия для ParallelTextBox.xaml
    /// </summary>
    public partial class ParallelTextBox : Window
    {
        public ParallelTextBox()
        {
            InitializeComponent();
            string ConnectionString = @"Data Source=SERGEY-PC;Initial Catalog=Kvadro;Integrated Security=True";
            System.Diagnostics.Stopwatch sw2 = System.Diagnostics.Stopwatch.StartNew();
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand com = new SqlCommand("SELECT * FROM EmployeeInfo", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            int nrec = 0;
            if (reader.HasRows)
            {


                Parallel.For(0, 1000, (rc) =>
                {
                    string s3 = "\r\n rc=" + rc.ToString() + " nrec=" + nrec.ToString() + " \r\n";
                    string s2;
                    lock (reader)
                    {

                        while (reader.Read())
                        {
                            text.Text+= reader.GetSqlValue(0).ToString()
                                           + "     " + reader.GetSqlValue(1).ToString()
                         + "     " + reader.GetSqlValue(2).ToString()
                         + "     " + reader.GetSqlValue(3).ToString()
                         + "     " + reader.GetSqlValue(4).ToString()
                         + "     " + reader.GetSqlValue(5).ToString()
                         + "     " + reader.GetSqlValue(6).ToString()
                         + "     " + reader.GetSqlValue(7).ToString()
                         + "     " + reader.GetSqlValue(8).ToString()
                         + "     " + reader.GetSqlValue(9).ToString()
                         + "     " + reader.GetSqlValue(10).ToString();

                        }
                        nrec++;
                    }
                });

                reader.Close();
                con.Close();
            }

            long elapsed = sw2.ElapsedMilliseconds;
            MessageBox.Show("Время выполнения: " + elapsed, "Кол-во записей:" + nrec);
        }
    }
}

