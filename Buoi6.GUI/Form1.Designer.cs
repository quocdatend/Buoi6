namespace Buoi6.GUI
{
    partial class frm_Student
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
            groupBox1 = new GroupBox();
            btb_Delete = new Button();
            btn_Add_Update = new Button();
            pictureBox1 = new PictureBox();
            cb_khoa = new ComboBox();
            txt_dtb = new TextBox();
            txt_name = new TextBox();
            txt_mssv = new TextBox();
            dgvStudent = new DataGridView();
            MSSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DTB = new DataGridViewTextBoxColumn();
            ChuyenNganh = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ckb_cn = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btb_Delete);
            groupBox1.Controls.Add(btn_Add_Update);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cb_khoa);
            groupBox1.Controls.Add(txt_dtb);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_mssv);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Sinh Vien";
            // 
            // btb_Delete
            // 
            btb_Delete.Location = new Point(220, 400);
            btb_Delete.Name = "btb_Delete";
            btb_Delete.Size = new Size(105, 30);
            btb_Delete.TabIndex = 6;
            btb_Delete.Text = "Delete";
            btb_Delete.UseVisualStyleBackColor = true;
            btb_Delete.Click += btb_Delete_Click;
            // 
            // btn_Add_Update
            // 
            btn_Add_Update.Location = new Point(33, 401);
            btn_Add_Update.Name = "btn_Add_Update";
            btn_Add_Update.Size = new Size(123, 29);
            btn_Add_Update.TabIndex = 5;
            btn_Add_Update.Text = "Add/Update";
            btn_Add_Update.UseVisualStyleBackColor = true;
            btn_Add_Update.Click += btn_Add_Update_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 124);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cb_khoa
            // 
            cb_khoa.FormattingEnabled = true;
            cb_khoa.Location = new Point(33, 168);
            cb_khoa.Name = "cb_khoa";
            cb_khoa.Size = new Size(282, 28);
            cb_khoa.TabIndex = 3;
            // 
            // txt_dtb
            // 
            txt_dtb.Location = new Point(33, 228);
            txt_dtb.Name = "txt_dtb";
            txt_dtb.PlaceholderText = "Diem Trung Binh";
            txt_dtb.Size = new Size(282, 27);
            txt_dtb.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(33, 108);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Ho Ten";
            txt_name.Size = new Size(282, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(33, 54);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.PlaceholderText = "Ma So Sinh Vien";
            txt_mssv.Size = new Size(282, 27);
            txt_mssv.TabIndex = 0;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { MSSV, HoTen, Khoa, DTB, ChuyenNganh });
            dgvStudent.Location = new Point(394, 102);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(751, 438);
            dgvStudent.TabIndex = 1;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "MSSV";
            MSSV.MinimumWidth = 6;
            MSSV.Name = "MSSV";
            MSSV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Ho Ten";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.Width = 125;
            // 
            // DTB
            // 
            DTB.HeaderText = "DTB";
            DTB.MinimumWidth = 6;
            DTB.Name = "DTB";
            DTB.Width = 125;
            // 
            // ChuyenNganh
            // 
            ChuyenNganh.HeaderText = "ChuyenNganh";
            ChuyenNganh.MinimumWidth = 6;
            ChuyenNganh.Name = "ChuyenNganh";
            ChuyenNganh.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(441, 26);
            label1.Name = "label1";
            label1.Size = new Size(256, 38);
            label1.TabIndex = 2;
            label1.Text = "Quản Lý Sinh Viên";
            // 
            // ckb_cn
            // 
            ckb_cn.AutoSize = true;
            ckb_cn.Location = new Point(1021, 72);
            ckb_cn.Name = "ckb_cn";
            ckb_cn.Size = new Size(124, 24);
            ckb_cn.TabIndex = 3;
            ckb_cn.Text = "Chuyên ngành";
            ckb_cn.UseVisualStyleBackColor = true;
            // 
            // frm_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 552);
            Controls.Add(ckb_cn);
            Controls.Add(label1);
            Controls.Add(dgvStudent);
            Controls.Add(groupBox1);
            Name = "frm_Student";
            Text = "Quản Lý Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btb_Delete;
        private Button btn_Add_Update;
        private PictureBox pictureBox1;
        private ComboBox cb_khoa;
        private TextBox txt_dtb;
        private TextBox txt_name;
        private TextBox txt_mssv;
        private DataGridView dgvStudent;
        private Label label1;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DTB;
        private DataGridViewTextBoxColumn ChuyenNganh;
        private CheckBox ckb_cn;
    }
}