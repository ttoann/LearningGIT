using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class PersonDAO
    {
        protected string tablename;
        DBConnection dbconn = new DBConnection();
        public DataTable FLoad()
        {
            string sqlStr = string.Format("SELECT *FROM  " + tablename+"");
            return dbconn.Load(sqlStr);
        }
        public void Add(Person p)
        {
            if (!Util.isFullInfo(p))
            {
                MessageBox.Show("thong tin khong hop le");
            }
            else
            {
                string sqlStr = string.Format("INSERT INTO " + tablename + "(Ten, Diachi, CMND, Ngaysinh, Email, SDT, GioiTinh) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", p.Name, p.Address, p.Id, p.Birth, p.Email, p.Phone, p.Gender);
                dbconn.Execute(sqlStr);
            }
        }
        public void Delete(Person p)
        {
            string sqlStr = string.Format("DELETE FROM " + tablename + " WHERE Cmnd = '{0}'", p.Id);
            dbconn.Execute(sqlStr);
        }
        public void Update(Person p)
        {
            if (!Util.isFullInfo(p))
            {
                MessageBox.Show("thong tin khong hop le");
            }
            else
            {
                string sqlStr = string.Format("UPDATE " + tablename + " SET Ten = '{0}', DiaChi = '{1}', Ngaysinh = '{2}', Email = '{3}', SDT = '{4}', GioiTinh = '{5}' WHERE Cmnd = '{6}'", p.Name, p.Address, p.Birth, p.Email, p.Phone, p.Gender, p.Id);
                dbconn.Execute(sqlStr);
            }
        }
    }
}
