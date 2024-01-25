using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH01
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO tchDAO = new TeacherDAO();
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Teacher tch = new Teacher(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value, txtEmail.Text, txtSDT.Text, txtGioitinh.Text);
            tchDAO.Add(tch);
            FGiaoVien_Load(sender, e);
        }

        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Teacher tch = new Teacher(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value, txtEmail.Text, txtSDT.Text, txtGioitinh.Text);
            tchDAO.Delete(tch);
            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Teacher tch = new Teacher(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value, txtEmail.Text, txtSDT.Text, txtGioitinh.Text);
            tchDAO.Update(tch);
            FGiaoVien_Load(sender, e);
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            gvGiaoVien.DataSource = tchDAO.FLoad();
        }
    }
}
