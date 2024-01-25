using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hoc_Sinh
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FHocSinh fhs = new FHocSinh();
            fhs.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FGiaoVien fgv = new FGiaoVien();
            fgv.Show();
        }
    }
}
