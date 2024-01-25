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
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO tcdao = new TeacherDAO();
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher st = new Teacher(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            tcdao.Add(st);
            FGiaoVien_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Teacher st = new Teacher(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            tcdao.Delete(st);
            FGiaoVien_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Teacher st = new Teacher(txtName.Text, txtAddress.Text, txtID.Text, txtMail.Text, txtPhone.Text, txtGender.Text, dtpBirthday.Value);
            tcdao.Edit(st);
            FGiaoVien_Load(sender, e);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FHocSinh fhs = new FHocSinh();
            fhs.Show();
        }

        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvGiaoVien.Rows[e.RowIndex];
                txtName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtID.Text = row.Cells[2].Value.ToString();
                txtMail.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                dtpBirthday.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                txtPhone.Text = row.Cells[6].Value.ToString();
            }
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            gvGiaoVien.DataSource = tcdao.Form_Load();
        }
    }
}
