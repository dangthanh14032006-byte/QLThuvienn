namespace baocao
{
    partial class QuanLySach
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
            dgvDocGia = new DataGridView();
            colMaDG = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colCMND = new DataGridViewTextBoxColumn();
            colNgayLamThe = new DataGridViewTextBoxColumn();
            dgvSach = new DataGridView();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colNhaXuatBan = new DataGridViewTextBoxColumn();
            colNgayXuatBan = new DataGridViewTextBoxColumn();
            colMaTG = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGiaTien = new DataGridViewTextBoxColumn();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            txtSoLuong = new TextBox();
            lblTimKiem = new Label();
            lblNgayLamThe = new Label();
            lblCMND = new Label();
            lblMaTG = new Label();
            lblNgayXuatBan = new Label();
            lblNhaXuatBan = new Label();
            lblTheLoai = new Label();
            lblTenSach = new Label();
            lblMaSach = new Label();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDocGia = new ToolStripMenuItem();
            mnuSach = new ToolStripMenuItem();
            mnuTacGia = new ToolStripMenuItem();
            mnuMuonTra = new ToolStripMenuItem();
            txtTheLoai = new TextBox();
            txtNhaXuatBan = new TextBox();
            dtpNgayXuatBan = new DateTimePicker();
            cboMaTG = new ComboBox();
            txtGiaTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocGia
            // 
            dgvDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { colMaDG, colHoTen, colNgaySinh, colGioiTinh, colDiaChi, colDienThoai, colCMND, colNgayLamThe });
            dgvDocGia.Location = new Point(10, 280);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1160, 0);
            dgvDocGia.TabIndex = 26;
            // 
            // colMaDG
            // 
            colMaDG.HeaderText = "Mã Độc Giả";
            colMaDG.MinimumWidth = 6;
            colMaDG.Name = "colMaDG";
            colMaDG.Width = 125;
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.Width = 125;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.Width = 125;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.Width = 125;
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.Width = 125;
            // 
            // colDienThoai
            // 
            colDienThoai.HeaderText = "Điẹn Thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            colDienThoai.Width = 125;
            // 
            // colCMND
            // 
            colCMND.HeaderText = "CMND";
            colCMND.MinimumWidth = 6;
            colCMND.Name = "colCMND";
            colCMND.Width = 125;
            // 
            // colNgayLamThe
            // 
            colNgayLamThe.HeaderText = "Ngày Làm Thẻ";
            colNgayLamThe.MinimumWidth = 6;
            colNgayLamThe.Name = "colNgayLamThe";
            colNgayLamThe.Width = 125;
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = Color.Silver;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colTenSach, colTheLoai, colNhaXuatBan, colNgayXuatBan, colMaTG, colSoLuong, colGiaTien });
            dgvSach.Location = new Point(10, 280);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1160, 330);
            dgvSach.TabIndex = 27;
            dgvSach.CellContentClick += dgvSach_CellContentClick;
            // 
            // colMaSach
            // 
            colMaSach.HeaderText = "Mã Sách";
            colMaSach.MinimumWidth = 6;
            colMaSach.Name = "colMaSach";
            colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            colTenSach.HeaderText = "Tên Sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            // 
            // colTheLoai
            // 
            colTheLoai.HeaderText = "Thể Loại";
            colTheLoai.MinimumWidth = 6;
            colTheLoai.Name = "colTheLoai";
            colTheLoai.ReadOnly = true;
            // 
            // colNhaXuatBan
            // 
            colNhaXuatBan.HeaderText = "Nhà Xuất Bản";
            colNhaXuatBan.MinimumWidth = 6;
            colNhaXuatBan.Name = "colNhaXuatBan";
            colNhaXuatBan.ReadOnly = true;
            // 
            // colNgayXuatBan
            // 
            colNgayXuatBan.HeaderText = "Ngày Xuất Bản";
            colNgayXuatBan.MinimumWidth = 6;
            colNgayXuatBan.Name = "colNgayXuatBan";
            colNgayXuatBan.ReadOnly = true;
            // 
            // colMaTG
            // 
            colMaTG.HeaderText = "Mã Tác Giả";
            colMaTG.MinimumWidth = 6;
            colMaTG.Name = "colMaTG";
            colMaTG.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colGiaTien
            // 
            colGiaTien.HeaderText = "Giá Tiền";
            colGiaTien.MinimumWidth = 6;
            colGiaTien.Name = "colGiaTien";
            colGiaTien.ReadOnly = true;
            // 
            // btnHienThi
            // 
            btnHienThi.Enabled = false;
            btnHienThi.Location = new Point(826, 228);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(100, 40);
            btnHienThi.TabIndex = 50;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(656, 228);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(486, 228);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 48;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(316, 228);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 47;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(886, 128);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 40);
            btnTimKiem.TabIndex = 46;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(853, 78);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 27);
            txtTimKiem.TabIndex = 45;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(583, 125);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(180, 27);
            txtSoLuong.TabIndex = 44;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(849, 38);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(135, 20);
            lblTimKiem.TabIndex = 42;
            lblTimKiem.Text = "Tìm Kiếm Mã Sách:";
            // 
            // lblNgayLamThe
            // 
            lblNgayLamThe.AutoSize = true;
            lblNgayLamThe.Font = new Font("Segoe UI", 9F);
            lblNgayLamThe.Location = new Point(456, 173);
            lblNgayLamThe.Name = "lblNgayLamThe";
            lblNgayLamThe.Size = new Size(66, 20);
            lblNgayLamThe.TabIndex = 41;
            lblNgayLamThe.Text = "Giá Tiền:";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(456, 128);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(75, 20);
            lblCMND.TabIndex = 40;
            lblCMND.Text = "Số Lượng:";
            // 
            // lblMaTG
            // 
            lblMaTG.AutoSize = true;
            lblMaTG.Location = new Point(456, 83);
            lblMaTG.Name = "lblMaTG";
            lblMaTG.Size = new Size(84, 20);
            lblMaTG.TabIndex = 39;
            lblMaTG.Text = "Mã Tác GIả:";
            // 
            // lblNgayXuatBan
            // 
            lblNgayXuatBan.AutoSize = true;
            lblNgayXuatBan.Location = new Point(456, 38);
            lblNgayXuatBan.Name = "lblNgayXuatBan";
            lblNgayXuatBan.Size = new Size(110, 20);
            lblNgayXuatBan.TabIndex = 38;
            lblNgayXuatBan.Text = "Ngày Xuất Bản:";
            // 
            // lblNhaXuatBan
            // 
            lblNhaXuatBan.AutoSize = true;
            lblNhaXuatBan.Location = new Point(36, 173);
            lblNhaXuatBan.Name = "lblNhaXuatBan";
            lblNhaXuatBan.Size = new Size(102, 20);
            lblNhaXuatBan.TabIndex = 37;
            lblNhaXuatBan.Text = "Nhà Xuất Bản:";
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Location = new Point(36, 128);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(68, 20);
            lblTheLoai.TabIndex = 36;
            lblTheLoai.Text = "Thể Loại:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(37, 83);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(70, 20);
            lblTenSach.TabIndex = 35;
            lblTenSach.Text = "Tên Sách:";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(36, 38);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(68, 20);
            lblMaSach.TabIndex = 34;
            lblMaSach.Text = "Mã Sách:";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(166, 78);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(180, 27);
            txtTenSach.TabIndex = 29;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(166, 33);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(180, 27);
            txtMaSach.TabIndex = 28;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDocGia, mnuSach, mnuTacGia, mnuMuonTra });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 51;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDocGia
            // 
            mnuDocGia.Name = "mnuDocGia";
            mnuDocGia.Size = new Size(132, 24);
            mnuDocGia.Text = "Quản Lý Độc Giả";
            // 
            // mnuSach
            // 
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(110, 24);
            mnuSach.Text = "Quản Lý Sách";
            // 
            // mnuTacGia
            // 
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(126, 24);
            mnuTacGia.Text = "Quản Lý Tác Giả";
            // 
            // mnuMuonTra
            // 
            mnuMuonTra.Name = "mnuMuonTra";
            mnuMuonTra.Size = new Size(142, 24);
            mnuMuonTra.Text = "Quản Lý Mượn Trả";
            // 
            // txtTheLoai
            // 
            txtTheLoai.Location = new Point(166, 125);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(180, 27);
            txtTheLoai.TabIndex = 52;
            // 
            // txtNhaXuatBan
            // 
            txtNhaXuatBan.Location = new Point(166, 168);
            txtNhaXuatBan.Name = "txtNhaXuatBan";
            txtNhaXuatBan.Size = new Size(180, 27);
            txtNhaXuatBan.TabIndex = 53;
            // 
            // dtpNgayXuatBan
            // 
            dtpNgayXuatBan.CustomFormat = "yyyy-MM-dd";
            dtpNgayXuatBan.Format = DateTimePickerFormat.Custom;
            dtpNgayXuatBan.Location = new Point(583, 39);
            dtpNgayXuatBan.Name = "dtpNgayXuatBan";
            dtpNgayXuatBan.Size = new Size(180, 27);
            dtpNgayXuatBan.TabIndex = 54;
            // 
            // cboMaTG
            // 
            cboMaTG.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaTG.FormattingEnabled = true;
            cboMaTG.Location = new Point(583, 80);
            cboMaTG.Name = "cboMaTG";
            cboMaTG.Size = new Size(180, 28);
            cboMaTG.TabIndex = 55;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(583, 170);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(180, 27);
            txtGiaTien.TabIndex = 56;
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(txtGiaTien);
            Controls.Add(cboMaTG);
            Controls.Add(dtpNgayXuatBan);
            Controls.Add(txtNhaXuatBan);
            Controls.Add(txtTheLoai);
            Controls.Add(menuStrip1);
            Controls.Add(btnHienThi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtSoLuong);
            Controls.Add(lblTimKiem);
            Controls.Add(lblNgayLamThe);
            Controls.Add(lblCMND);
            Controls.Add(lblMaTG);
            Controls.Add(lblNgayXuatBan);
            Controls.Add(lblNhaXuatBan);
            Controls.Add(lblTheLoai);
            Controls.Add(lblTenSach);
            Controls.Add(lblMaSach);
            Controls.Add(txtTenSach);
            Controls.Add(txtMaSach);
            Controls.Add(dgvSach);
            Controls.Add(dgvDocGia);
            Name = "QuanLySach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thư Viện - Quản Lý Sách";
            Load += QuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDocGia;
        private DataGridViewTextBoxColumn colMaDG;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colCMND;
        private DataGridViewTextBoxColumn colNgayLamThe;
        private DataGridView dgvSach;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtSoLuong;
        private Label lblTimKiem;
        private Label lblNgayLamThe;
        private Label lblCMND;
        private Label lblMaTG;
        private Label lblNgayXuatBan;
        private Label lblNhaXuatBan;
        private Label lblTheLoai;
        private Label lblTenSach;
        private Label lblMaSach;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDocGia;
        private ToolStripMenuItem mnuSach;
        private ToolStripMenuItem mnuTacGia;
        private ToolStripMenuItem mnuMuonTra;
        private TextBox txtTheLoai;
        private TextBox txtNhaXuatBan;
        private DateTimePicker dtpNgayXuatBan;
        private ComboBox cboMaTG;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colNhaXuatBan;
        private DataGridViewTextBoxColumn colNgayXuatBan;
        private DataGridViewTextBoxColumn colMaTG;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGiaTien;
        private TextBox txtGiaTien;
    }
}