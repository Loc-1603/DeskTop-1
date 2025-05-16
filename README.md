using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        string filePath = "dulieu.txt";

        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 4)
                {
                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    item.SubItems.Add(parts[2]);
                    item.SubItems.Add(parts[3]);
                    lvNhanVien.Items.Add(item);
                }
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0) return;

            ListViewItem selected = lvNhanVien.SelectedItems[0];
            txtMaSo.Text = selected.SubItems[0].Text;
            txtHoTen.Text = selected.SubItems[1].Text;
            txtNgaySinh.Text = selected.SubItems[2].Text;
            txtEmail.Text = selected.SubItems[3].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaSo.Text;
            string hoTen = txtHoTen.Text;
            string ngaySinh = txtNgaySinh.Text;
            string email = txtEmail.Text;

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(hoTen);
            item.SubItems.Add(ngaySinh);
            item.SubItems.Add(email);
            lvNhanVien.Items.Add(item);

            File.AppendAllText(filePath, $"{ma};{hoTen};{ngaySinh};{email}{Environment.NewLine}");

            btnLuu.Enabled = false;
        }
    }
}
