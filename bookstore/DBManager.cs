//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace bookstore
//{
//    internal class DBManager
//    {
//        private static DBManager instance = null;
//        public DBManager()
//        {
//            connectionString = "Server=localhost; Database=bookstore; User id=prac; Password=1234;";
//            conn = new SqlConnection(connectionString);
//            OpenConnection();
//        }
//        public static DBManager Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new DBManager();
//                }
//                return instance;
//            }
//        }

//        private SqlConnection conn;
//        private string connectionString;
//        private SqlCommand cmd;

//        public void OpenConnection()
//        {
//            try
//            {
//                conn.Open();
//                cmd = new SqlCommand();
//                cmd.Connection = conn;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("OpenConnection에서 오류 발생 : " + ex.Message);
//            }
//        }

//        public void CloseConnection()
//        {
//            try
//            {
//                if (conn != null && conn.State == System.Data.ConnectionState.Open)
//                {
//                    conn.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("CloseConnection에서 오류 발생 : " + ex.Message);
//            }
//        }

//        //select문
//        public List<string[]> GetData(string query) //-----전체 테이블
//        {
//            List<string[]> resultList = new List<string[]>();
//            cmd.CommandText = query;
//            try
//            {
//                SqlDataReader reader = cmd.ExecuteReader();

//                while (reader.Read())
//                {
//                    string[] row = new string[2];
//                    row[0] = reader["id"].ToString();
//                    row[1] = reader["author"].ToString();
//                    row[1] = reader["price"].ToString();
//                    row[1] = reader["publisher_id"].ToString();
//                    resultList.Add(row);
//                }
//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("GetData에서 오류 : " + ex.Message);
//            }
//            return resultList;
//        }

//        public List<string[]> GetData(string query, string[] colums, params object[] parameters)
//        {
//            var resultList = new List<string[]>();
//            try
//            {
//                cmd.CommandText = query;
//                cmd.Parameters.Clear();
//                if ((parameters != null) && parameters.Length > 0)
//                {
//                    for (int i = 0; i < parameters.Length; i++)
//                    {
//                        cmd.Parameters.AddWithValue($"@p{i + 1}", parameters[i] ?? DBNull.Value);
//                    }
//                }

//                SqlDataReader reader = cmd.ExecuteReader();

//                while(reader.Read())
//                {
//                    String[] row = new string[colums.Length];

//                    for (int i = 0;i < colums.Length;i++)
//                    {
//                        row[i] = reader[colums[i]].ToString();
//                    }
//                    resultList.Add(row);
//                }
//                reader.Close();
//            }catch (Exception ex)
//            {
//                MessageBox.Show("GetData 에서 오류 :" + ex);
//            }
//            return resultList;
//        }

//        //쿼리문 실행
//        public void ExecuteQuery(string query, params object[] parameters)
//        {
//            try
//            {
//                cmd.CommandText = query;
//                cmd.Parameters.Clear();

//                if((parameters != null) && parameters.Length > 0)
//                {
//                    for(int i = 0; i < parameters.Length; i++)
//                    {
//                        cmd.Parameters.AddWithValue($"@p{i + 1}", parameters [i] ?? DBNull.Value);
//                    }
//                    cmd.ExecuteNonQuery();
//                }
//            }catch (Exception ex)
//            {
//                MessageBox.Show("ExcuteQuery 에서 오류 발생 :" + ex);
//            }
//        }

//        public void ExecuteQuery(string query)
//        {
//            try
//            {
//                cmd.CommandText = query;
//                var data = cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("ExcuteQuery 에서 오류 발생 :" + ex);
//            }
//        }


//        // 문제
//        public void ExecuteQuery(string query, string param1, string param2)
//        {
//            try
//            {
//                cmd.CommandText = query;
//                cmd.Parameters.Clear();
//                cmd.Parameters.Add("@sno", SqlDbType.Int);

//                // -------------------
//                cmd.Parameters.Add("@sname", SqlDbType.VarChar);
//                cmd.Parameters["@sno"].Value = param1;
//                cmd.Parameters["@sname"].Value = param2;
//                // -------------------

//                var data = cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("ExcuteQuery 에서 오류 발생 :" + ex);
//            }
//        }


//    }
//}



using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bookstore
{
    internal class DBManager
    {
        private static DBManager instance = null;
        private SqlConnection conn;
        private string connectionString;
        private SqlCommand cmd;

        public DBManager()
        {
            connectionString = "Server=localhost; Database=bookstore; User id=prac; Password=1234;";
            conn = new SqlConnection(connectionString);
            OpenConnection();
        }

        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBManager();
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand { Connection = conn };
            }
            catch (Exception ex)
            {
                MessageBox.Show("OpenConnection에서 오류 발생 : " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CloseConnection에서 오류 발생 : " + ex.Message);
            }
        }

        // GetData 메서드 수정: 열 이름을 동적으로 지정하여 book 및 publisher 테이블 모두에서 사용 가능
        public List<string[]> GetData(string query, string[] columns, params object[] parameters)
        {
            var resultList = new List<string[]>();
            try
            {
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                // 파라미터 추가
                if ((parameters != null) && parameters.Length > 0)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i + 1}", parameters[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = new string[columns.Length];
                    for (int i = 0; i < columns.Length; i++)
                    {
                        row[i] = reader[columns[i]].ToString();
                    }
                    resultList.Add(row);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetData에서 오류 : " + ex.Message);
            }
            return resultList;
        }

        // 범용 ExecuteQuery 메서드
        public void ExecuteQuery(string query, params object[] parameters)
        {
            try
            {
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                // 파라미터 추가
                if ((parameters != null) && parameters.Length > 0)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i + 1}", parameters[i] ?? DBNull.Value);
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteQuery에서 오류 발생 : " + ex.Message);
            }
        }
    }
}
