namespace Quan_Ly_Hoc_Sinh
{
    partial class FHocSinh
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
            txtGender = new TextBox();
            lblGender = new Label();
            txtMail = new TextBox();
            lblMail = new Label();
            gvHocSinh = new DataGridView();
            dtpBirthday = new DateTimePicker();
            txtID = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblBirthday = new Label();
            lblID = new Label();
            lblAddress = new Label();
            lblName = new Label();
            btnTeacher = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lblPhone = new Label();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // txtGender
            // 
            txtGender.Location = new Point(192, 290);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(200, 23);
            txtGender.TabIndex = 33;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(14, 290);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 32;
            lblGender.Text = "Gender";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(192, 202);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 23);
            txtMail.TabIndex = 31;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(15, 202);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 30;
            lblMail.Text = "Mail";
            // 
            // gvHocSinh
            // 
            gvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHocSinh.Location = new Point(414, 49);
            gvHocSinh.Name = "gvHocSinh";
            gvHocSinh.RowTemplate.Height = 25;
            gvHocSinh.Size = new Size(553, 352);
            gvHocSinh.TabIndex = 29;
            gvHocSinh.CellContentClick += gvHocSinh_CellContentClick;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(192, 335);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 28;
            // 
            // txtID
            // 
            txtID.Location = new Point(192, 155);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(192, 102);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 25;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(14, 335);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(51, 15);
            lblBirthday.TabIndex = 24;
            lblBirthday.Text = "Birthday";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(14, 155);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 23;
            lblID.Text = "ID";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 110);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 22;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 15);
            lblName.TabIndex = 21;
            lblName.Text = "Fullname";
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(317, 378);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(75, 23);
            btnTeacher.TabIndex = 20;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(208, 378);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(110, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(14, 245);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(192, 242);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 35;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 438);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtGender);
            Controls.Add(lblGender);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(gvHocSinh);
            Controls.Add(dtpBirthday);
            Controls.Add(txtID);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(lblBirthday);
            Controls.Add(lblID);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(btnTeacher);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "FHocSinh";
            Text = "FHocSinh";
            Load += FHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)gvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGender;
        private Label lblGender;
        private TextBox txtMail;
        private Label lblMail;
        private DataGridView gvHocSinh;
        private DateTimePicker dtpBirthday;
        private TextBox txtID;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblBirthday;
        private Label lblID;
        private Label lblAddress;
        private Label lblName;
        private Button btnTeacher;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblPhone;
        private TextBox txtPhone;
    }
}