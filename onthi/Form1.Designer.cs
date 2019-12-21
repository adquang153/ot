namespace onthi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnXoaNhom = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnThemll = new System.Windows.Forms.ToolStripButton();
            this.btnXoall = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gvNhom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLienLac = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDchi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnXoaNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLienLac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.toolStripButton2,
            this.btnThemll,
            this.btnXoall,
            this.txtSearch,
            this.toolStripLabel1});
            this.btnXoaNhom.Location = new System.Drawing.Point(0, 0);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(815, 25);
            this.btnXoaNhom.TabIndex = 0;
            this.btnXoaNhom.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhom.Image = global::onthi.Properties.Resources.add;
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(93, 22);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.BtnThemNhom_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::onthi.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton2.Text = "Xóa nhóm";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // btnThemll
            // 
            this.btnThemll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemll.Image = global::onthi.Properties.Resources.plus;
            this.btnThemll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemll.Name = "btnThemll";
            this.btnThemll.Size = new System.Drawing.Size(98, 22);
            this.btnThemll.Text = "Thêm liên lạc";
            this.btnThemll.Click += new System.EventHandler(this.BtnThemll_Click);
            // 
            // btnXoall
            // 
            this.btnXoall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoall.Image = global::onthi.Properties.Resources.delete__1_;
            this.btnXoall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoall.Name = "btnXoall";
            this.btnXoall.Size = new System.Drawing.Size(87, 22);
            this.btnXoall.Text = "Xóa liên lạc";
            this.btnXoall.Click += new System.EventHandler(this.BtnXoall_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Nhập từ tìm kiếm";
            // 
            // gvNhom
            // 
            this.gvNhom.AllowUserToAddRows = false;
            this.gvNhom.AllowUserToDeleteRows = false;
            this.gvNhom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvNhom.Location = new System.Drawing.Point(4, 28);
            this.gvNhom.Name = "gvNhom";
            this.gvNhom.ReadOnly = true;
            this.gvNhom.Size = new System.Drawing.Size(209, 410);
            this.gvNhom.TabIndex = 1;
            this.gvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvNhom_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenNhom";
            this.Column1.HeaderText = "Tên Nhóm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // gvLienLac
            // 
            this.gvLienLac.AllowUserToAddRows = false;
            this.gvLienLac.AllowUserToDeleteRows = false;
            this.gvLienLac.AutoGenerateColumns = false;
            this.gvLienLac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gvLienLac.DataSource = this.bds2;
            this.gvLienLac.Location = new System.Drawing.Point(219, 28);
            this.gvLienLac.Name = "gvLienLac";
            this.gvLienLac.ReadOnly = true;
            this.gvLienLac.Size = new System.Drawing.Size(592, 236);
            this.gvLienLac.TabIndex = 2;
            this.gvLienLac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvLienLac_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenGoi";
            this.Column2.HeaderText = "Tên Liên Lạc";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DiaChi";
            this.Column6.HeaderText = "Địa Chỉ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TenNhom";
            this.Column5.HeaderText = "Tên Nhóm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(237, 284);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(110, 29);
            this.lblTenGoi.TabIndex = 3;
            this.lblTenGoi.Text = "[Tên gọi]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa Chỉ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại: ";
            // 
            // lblDchi
            // 
            this.lblDchi.AutoSize = true;
            this.lblDchi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDchi.Location = new System.Drawing.Point(372, 325);
            this.lblDchi.Name = "lblDchi";
            this.lblDchi.Size = new System.Drawing.Size(31, 25);
            this.lblDchi.TabIndex = 7;
            this.lblDchi.Text = "dc";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(372, 364);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "em";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(373, 401);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(37, 25);
            this.lblSdt.TabIndex = 9;
            this.lblSdt.Text = "sdt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 447);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenGoi);
            this.Controls.Add(this.gvLienLac);
            this.Controls.Add(this.gvNhom);
            this.Controls.Add(this.btnXoaNhom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH BẠ - QUANG LÊ";
            this.btnXoaNhom.ResumeLayout(false);
            this.btnXoaNhom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLienLac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnThemll;
        private System.Windows.Forms.ToolStripButton btnXoall;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView gvNhom;
        private System.Windows.Forms.DataGridView gvLienLac;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDchi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.BindingSource bds2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

