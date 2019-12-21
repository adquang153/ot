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
    public partial class ThemNhom : Form
    {
        private List<NhomDanhBa> ndb = NhomDanhBa.GetFromNDB();
        public ThemNhom()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String t = txtTN.Text;
            var a = new NhomDanhBa();
            foreach(NhomDanhBa i in ndb)
            {
                if (i.TenNhom.Trim().Equals(t))
                {
                    MessageBox.Show("Tên Nhóm đã tồn tại", "Thông Báo");
                }
                else
                {
                    a = new NhomDanhBa { TenNhom = t };
                }
            }
            NhomDanhBa.Add(a);
            MessageBox.Show("Đã thêm nhóm: " + t);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
