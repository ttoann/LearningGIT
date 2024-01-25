using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Execute(string sql)
        {
            try
            {
                //Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thuc thi thanh cong");
                else MessageBox.Show("khong ton tai");
            }

            catch (Exception ex)
            {
                MessageBox.Show("thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string sql)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

            finally
            {
                conn.Close();
            }
            return new DataTable();
        }

    }
}
