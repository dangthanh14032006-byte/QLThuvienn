using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocao
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }
        private List<Sach> danhSachSach = new List<Sach>();

        public class Sach
        {
            public string MaSach { get; set; }
            public string TenSach { get; set; }
            public string TheLoai { get; set; }
            public string NhaXuatBan { get; set; }
            public DateTime NgayXuatBan { get; set; }
            public string MaTacGia { get; set; }
            public int SoLuong { get; set; }
            public decimal GiaTien { get; set; }
        }

        private void HienThiDanhSach()
        {
            dgvSach.AutoGenerateColumns = false;
            dgvSach.DataSource = null;
            dgvSach.DataSource = danhSachSach.ToList();
        
 }
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách và tên sách!");
                return;
            }

            if (danhSachSach.Any(s =>
                s.MaSach.Equals(txtMaSach.Text.Trim(),
                StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) ||
                soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            if (!decimal.TryParse(txtGiaTien.Text, out decimal giaTien) ||
                giaTien < 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                return;
            }

            Sach sach = new Sach
            {
                MaSach = txtMaSach.Text.Trim(),
                TenSach = txtTenSach.Text.Trim(),
                TheLoai = txtTheLoai.Text.Trim(),
                NhaXuatBan = txtNhaXuatBan.Text.Trim(),
                NgayXuatBan = dtpNgayXuatBan.Value,
                MaTacGia = cboMaTG.Text.Trim(),
                SoLuong = soLuong,
                GiaTien = giaTien
            };

            danhSachSach.Add(sach);

            HienThiDanhSach();

            MessageBox.Show("Thêm sách thành công!");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow == null ||
                dgvSach.CurrentRow.DataBoundItem is not Sach sach)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!");
                return;
            }

            if (txtTenSach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) ||
                soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            if (!decimal.TryParse(txtGiaTien.Text, out decimal giaTien) ||
                giaTien < 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!");
                return;
            }

            sach.TenSach = txtTenSach.Text.Trim();
            sach.TheLoai = txtTheLoai.Text.Trim();
            sach.NhaXuatBan = txtNhaXuatBan.Text.Trim();
            sach.NgayXuatBan = dtpNgayXuatBan.Value;
            sach.MaTacGia = cboMaTG.Text.Trim();
            sach.SoLuong = soLuong;
            sach.GiaTien = giaTien;

            HienThiDanhSach();

            MessageBox.Show("Sửa thông tin sách thành công!");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow == null ||
                dgvSach.CurrentRow.DataBoundItem is not Sach sach)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sách này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                danhSachSach.Remove(sach);

                HienThiDanhSach();

                MessageBox.Show("Xóa sách thành công!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            var ketQua = danhSachSach.Where(s =>
                s.MaSach.Contains(tuKhoa,
                    StringComparison.OrdinalIgnoreCase) ||
                s.TenSach.Contains(tuKhoa,
                    StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dgvSach.DataSource = null;
            dgvSach.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sách!");
            }
        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSach.Rows[e.RowIndex].DataBoundItem is not Sach sach)
                return;

            txtMaSach.Text = sach.MaSach;
            txtTenSach.Text = sach.TenSach;
            txtTheLoai.Text = sach.TheLoai;
            txtNhaXuatBan.Text = sach.NhaXuatBan;
            dtpNgayXuatBan.Value = sach.NgayXuatBan;
            cboMaTG.Text = sach.MaTacGia;
            txtSoLuong.Text = sach.SoLuong.ToString();
            txtGiaTien.Text = sach.GiaTien.ToString();
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
            MessageBox.Show("Đã hiển thị danh sách sách!");
        }
        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi nhấn vào nội dung ô trong bảng
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuHeThong_Click(object sender, EventArgs e)
        {

        }
        private void mnuDocGia_Click(object sender, EventArgs e)
        {
           
        }
        private void mnuSach_Click(object sender, EventArgs e)
        {
            
        }
        private void mnuTacGia_Click(object sender, EventArgs e)
        {
        }
        
       
    }
}
