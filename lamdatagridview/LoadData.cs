using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace lamdatagridview
{
   public class LoadData
    {
        private static LoadData instance;

        private String sqlString = @"Data Source=DESKTOP-3N66U8D;Initial Catalog=qlykhachsan;Integrated Security=True";

        public static LoadData Instance
        {
            get { if (instance == null) instance = new LoadData(); return instance; }
            private set { instance = value; }
        }
        public DataTable ExcuteQuery(String query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    String[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (String param in listParam)
                    {
                        if (param.Contains('@'))
                        {
                            sqlCommand.Parameters.Add(param, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExcuteNoneQuery(String query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                data = sqlCommand.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query)
        {
            object data = new object();
            using (SqlConnection connection = new SqlConnection(sqlString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                data = sqlCommand.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
