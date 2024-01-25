using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH01
{
    internal class TeacherDAO : PersonDAO
    {
        public TeacherDAO()
        {
            tablename = "GiaoVien";
        }
    }
}
