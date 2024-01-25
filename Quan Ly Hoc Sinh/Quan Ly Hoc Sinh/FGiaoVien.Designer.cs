namespace Quan_Ly_Hoc_Sinh
{
    partial class FGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvGiaoVien = new DataGridView();
            dtpBirthday = new DateTimePicker();
            txtID = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblBirthday = new Label();
            lblID = new Label();
            lblAddress = new Label();
            lblName = new Label();
            btnStudent = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtGender = new TextBox();
            lblGender = new Label();
            txtMail = new TextBox();
            lblMail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            ((System.ComponentModel.ISupportInitialize)gvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // gvGiaoVien
            // 
            gvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvGiaoVien.Location = new Point(414, 49);
            gvGiaoVien.Name = "gvGiaoVien";
            gvGiaoVien.RowTemplate.Height = 25;
            gvGiaoVien.Size = new Size(643, 352);
            gvGiaoVien.TabIndex = 25;
            gvGiaoVien.CellContentClick += gvGiaoVien_CellContentClick;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(192, 333);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 24;
            // 
            // txtID
            // 
            txtID.Location = new Point(192, 156);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 23;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(192, 103);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 21;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(14, 333);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(51, 15);
            lblBirthday.TabIndex = 20;
            lblBirthday.Text = "Birthday";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(14, 156);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 19;
            lblID.Text = "ID";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 111);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 15);
            lblName.TabIndex = 17;
            lblName.Text = "Fullname";
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(317, 378);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(75, 23);
            btnStudent.TabIndex = 16;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(208, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(110, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(192, 290);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(200, 23);
            txtGender.TabIndex = 29;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(14, 290);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 28;
            lblGender.Text = "Gender";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(192, 203);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 23);
            txtMail.TabIndex = 27;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(15, 203);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 26;
            lblMail.Text = "Mail";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(192, 245);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 37;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(14, 248);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 36;
            lblPhone.Text = "Phone";
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 450);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtGender);
            Controls.Add(lblGender);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(gvGiaoVien);
            Controls.Add(dtpBirthday);
            Controls.Add(txtID);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(lblBirthday);
            Controls.Add(lblID);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(btnStudent);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)gvGiaoVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvGiaoVien;
        private DateTimePicker dtpBirthday;
        private TextBox txtID;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblBirthday;
        private Label lblID;
        private Label lblAddress;
        private Label lblName;
        private Button btnStudent;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtGender;
        private Label lblGender;
        private TextBox txtMail;
        private Label lblMail;
        private TextBox txtPhone;
        private Label lblPhone;
    }
}