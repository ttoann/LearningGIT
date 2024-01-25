namespace Quan_Ly_Hoc_Sinh
{
    partial class FLogin
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
            btnStudent = new Button();
            btnTeacher = new Button();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.Location = new Point(107, 84);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(159, 67);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeacher.Location = new Point(290, 84);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(159, 67);
            btnTeacher.TabIndex = 1;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 238);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Name = "FLogin";
            Text = "FLogin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudent;
        private Button btnTeacher;
    }
}