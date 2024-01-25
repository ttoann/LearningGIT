using Microsoft.Data.SqlClient;
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
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO stdao = new StudentDAO();
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            gvHocSinh.DataSource = stdao.Form_Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            stdao.Add(st);
            FHocSinh_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            stdao.Delete(st);
            FHocSinh_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            stdao.Edit(st);
            FHocSinh_Load(sender, e);
        }

        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvHocSinh.Rows[e.RowIndex];
                txtName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtID.Text = row.Cells[2].Value.ToString();
                txtMail.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                dtpBirthday.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                txtPhone.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FGiaoVien fgv = new FGiaoVien();
            fgv.Show();
        }
    }
}
