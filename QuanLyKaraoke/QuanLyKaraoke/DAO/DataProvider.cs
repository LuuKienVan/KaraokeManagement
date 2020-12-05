using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKaraoke.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionString = "Data Source=.\\;Initial Catalog = QL_KARAOKE; Integrated Security = True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query,conn);

                if (parameter != null)
                {
                    string[] listOfParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listOfParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                conn.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listOfParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listOfParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = command.ExecuteNonQuery();

                conn.Close();
            }

            return dt;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listOfParameter = query.Split(' ');
                    int i = 0;
                    foreach (string item in listOfParameter)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = command.ExecuteScalar();

                conn.Close();
            }

            return dt;
        }
    }
}
