using onthi.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi
{
    public partial class ThemLienLac : Form
    {
        
        public ThemLienLac(int a=0)
        {
            InitializeComponent();
            List<NhomDanhBa> ndb = NhomDanhBa.GetFromNDB();
            foreach(NhomDanhBa i in ndb) {
                cbbTenNhom.Items.Add(i.TenNhom);
            }
            cbbTenNhom.SelectedIndex = a;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!txtTenLL.Text.Trim().Equals("")
                && !txtSDT.Text.Trim().Equals("")
                && !txtDC.Text.Trim().Equals("")
                && !txtE.Text.Trim().Equals(""))
            {
                int kt = 0;
                String t = txtSDT.Text;
                if (t.Length > 12)
                    MessageBox.Show("Số điện thoại chỉ gồm 11 số");
                else
                {
                    try
                    {
                        foreach (char i in t)
                        {
                            if (int.Parse(i.ToString()) < 0 && int.Parse(i.ToString()) > 9)
                            {
                                kt++;
                                MessageBox.Show("Số điện thoại chỉ bao gồm số");
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Số điện thoại chỉ bao gồm số");
                        kt++;
                    }
                    if (kt == 0)
                    {
                        var a = new ChiTietDanhBa
                        {
                            TenGoi = txtTenLL.Text,
                            DiaChi = txtDC.Text,
                            Email = txtE.Text,
                            SDT = txtSDT.Text,
                            TenNhom = cbbTenNhom.SelectedItem.ToString()
                        };
                        ChiTietDanhBa.Addctdb(a);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
            }
            else
                MessageBox.Show("Dữ liệu phải được nhập đầy đủ", "Thông báo!");
        }
    }
}
