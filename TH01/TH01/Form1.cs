using System.Data;
using System.Data.SqlClient;

namespace TH01
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO stdDAO = new StudentDAO();
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string gd = string.Empty;
            if (rdoNam.Checked) gd = "Nam";
            else if (rdoNu.Checked) gd = "Nu";
            Student std = new Student(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value,txtEmail.Text,txtSDT.Text, gd);
            stdDAO.Add(std);
            FHocSinh_Load(sender,e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string gd = string.Empty;
            if (rdoNam.Checked) gd = "Nam";
            else if (rdoNu.Checked) gd = "Nu";
            Student std = new Student(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value, txtEmail.Text, txtSDT.Text, gd);
            stdDAO.Delete(std);
            FHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gd = string.Empty;
            if (rdoNam.Checked) gd = "Nam";
            else if (rdoNu.Checked) gd = "Nu";
            Student std = new Student(txtHovaTen.Text, txtDiachi.Text, txtCMND.Text, dtpNgaysinh.Value, txtEmail.Text, txtSDT.Text, gd);
            stdDAO.Update(std);
            FHocSinh_Load(sender, e);
        }

        private void gvHocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = gvHocsinh.Rows[index];
            txtHovaTen.Text = selectedRow.Cells[0].Value.ToString();
            txtDiachi.Text = selectedRow.Cells[1].Value.ToString();
            txtCMND.Text = selectedRow.Cells[2].Value.ToString();
            DateTime date = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            dtpNgaysinh.Value = date;
        }

        private void btnMoGV_Click(object sender, EventArgs e)
        {
            FGiaoVien fgv = new FGiaoVien();
            fgv.Show();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            gvHocsinh.DataSource = stdDAO.FLoad();
        }
    }
}