using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh
{
    internal class StudentDAO : PersonDAO
    {
        public StudentDAO() 
        {
            tablename = "HocSinh";    
        }
    }
}
