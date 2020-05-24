using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MyLibrary
{
    public class MySQLDB
    {
        //Khai bao duong ket noi
        private string strConnect = FunctionStatic.strConnect;

        //tao bien sqlconnection
        SqlConnection conn;

        //Phuong thuc khoi tao
        public MySQLDB()
        {
            conn = new SqlConnection(strConnect);
        }

        //Ham kiem tra xem ket noi co thanh cong hay khong
        public bool isConnect()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //Ham Mo ket noi
        public bool openConnect()
        {
            if (!isConnect())
                return false;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return true;
        }

        //Ham dong ket noi
        public bool closeConnect()
        {
            if (!isConnect())
                return false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return true;
        }

        /// <summary>
        /// ham lay nhanh du lieu tu db do vao data table.
        /// </summary>
        /// <param name="query">la mot cau truy van bat ky</param>
        /// <returns></returns>
        public DataTable getDataToDatatable(string query)
        {
            DataTable dt = new DataTable();
            //kiem tra ket noi;
            bool isConnect = openConnect();
            if (isConnect)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                closeConnect();
                return dt;
            }

            return null;
        }

        /// <summary>
        /// ham thuc thi cau lenh insert, delete, update.
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>Mot so duong neu thuc thi thanh cong, -1 neu khong thanh cong.</returns>
        public int executeNow(SqlCommand cmd)
        {
            bool isConnect = openConnect();
            if (isConnect)
            {
                cmd.Connection = conn;
                return cmd.ExecuteNonQuery();
            }

            return -1;
        }
    }
}
