using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh
{
    internal class PersonDAO
    {
        protected string tablename;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection dbc = new DBConnection();
        public PersonDAO() { }
        public void Add(Person person)
        {
            if (!Util.isFullInfo(person)) 
            {
                MessageBox.Show("thong tin khong hop le");
            } else
            {
                string sqlStr = string.Format("INSERT INTO " + tablename + "(Name , Address, ID, Mail, Phone, Gender, Birthday) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", person.Name, person.Address, person.ID, person.Mail, person.Phone, person.Gender, person.Birthday.ToString("yyyy-MM-dd"));
                dbc.Execute(sqlStr);
            }
        }
        public void Delete(Person person)
        {
            string sqlStr = string.Format("DELETE FROM " + tablename + " WHERE ID = '{0}'", person.ID);
            dbc.Execute(sqlStr);
        }
        public void Edit(Person person)
        {
            if (!Util.isFullInfo(person))
            {
                MessageBox.Show("thong tin khong hop le");
            } else
            {
                string sqlStr = string.Format("UPDATE " + tablename + " SET Name = '{0}', Address = '{1}', Mail = '{2}', Phone = '{3}', Gender = '{4}', Birthday = '{5}' WHERE ID = '{6}'", person.Name, person.Address, person.Mail, person.Phone, person.Gender, person.Birthday.ToString("yyyy-MM-dd"), person.ID);
                dbc.Execute(sqlStr);
            }
        }
        public DataTable Form_Load()
        {
            string sqlStr = string.Format("SELECT *FROM " + tablename + "");
            return dbc.Load(sqlStr);
        }
    }
}
