namespace WinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaSo, txtHoTen, txtNgaySinh, txtEmail;
        private System.Windows.Forms.Button btnThem, btnLuu;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader colMaSo, colHoTen, colNgaySinh, colEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lvNhanVien = new System.Windows.Forms.ListView();

            this.colMaSo = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();

            // TextBoxes và Buttons
            this.txtMaSo.Location = new System.Drawing.Point(20, 20);
            this.txtHoTen.Location = new System.Drawing.Point(20, 50);
            this.txtNgaySinh.Location = new System.Drawing.Point(20, 80);
            this.txtEmail.Location = new System.Drawing.Point(20, 110);

            this.txtMaSo.Width = this.txtHoTen.Width = this.txtNgaySinh.Width = this.txtEmail.Width = 200;

            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(250, 20);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(250, 60);
            this.btnLuu.Enabled = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // ListView
            this.lvNhanVien.Location = new System.Drawing.Point(20, 150);
            this.lvNhanVien.Size = new System.Drawing.Size(400, 200);
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSo, this.colHoTen, this.colNgaySinh, this.colEmail });

            this.colMaSo.Text = "Mã số";
            this.colMaSo.Width = 80;
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 100;
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 100;
            this.colEmail.Text = "Email";
            this.colEmail.Width = 120;

            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lvNhanVien);
            this.Text = "Danh sách nhân viên";
        }
    }
}
