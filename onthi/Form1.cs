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
    public partial class Form1 : Form
    {
        private List<NhomDanhBa> ndb;
        private List<ChiTietDanhBa> ctdb;
        public Form1()
        {
            InitializeComponent();
            LoadNhom();
            ctdb = ChiTietDanhBa.GetFromCTDB(ndb[0].TenNhom);
            bds2.DataSource = ctdb;
            gvLienLac.DataSource = bds2;
            Load();
        }
        private void Load()
        {
            if (ctdb.Count > 0)
            {
                var a = ctdb[0];
                lblTenGoi.Text = a.TenGoi;
                lblEmail.Text = a.Email;
                lblSdt.Text = a.SDT;
                lblDchi.Text = a.DiaChi;
            }
            else
            {
                lblTenGoi.Text = "Chọn liên lạc";
                lblEmail.Text = "";
                lblSdt.Text = "";
                lblDchi.Text = "";
            }
        }
       
        private void LoadNhom()
        {
            ndb = NhomDanhBa.GetFromNDB();
            bds1.DataSource = ndb;
            gvNhom.DataSource = bds1;
            if (gvNhom.CurrentRow != null)
            {
                String n = gvNhom.CurrentRow.Cells[0].Value.ToString();
                ctdb = ChiTietDanhBa.GetFromCTDB(n.Trim());
                bds2.DataSource = ctdb;
                gvLienLac.DataSource = bds2;
            }
        }
        private void GvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadNhom();
            txtSearch.Text = "";
            //var a = (NhomDanhBa)bds1.Current;
            //ctdb = ChiTietDanhBa.GetFromCTDB(a.TenNhom);
            //bds2.DataSource = ctdb;
            //gvLienLac.DataSource = bds2;
            Load();
        }

        private void GvLienLac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = (ChiTietDanhBa)bds2.Current;
            lblTenGoi.Text = a.TenGoi;
            lblEmail.Text = a.Email;
            lblSdt.Text = a.SDT;
            lblDchi.Text = a.DiaChi;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            
            List<ChiTietDanhBa> dbc = new List<ChiTietDanhBa>();
            dbc.Clear();
            String t = txtSearch.Text;
            foreach (ChiTietDanhBa a in ctdb)
                if (a.TenGoi.Trim().ToLower().Contains(t))
                    dbc.Add(a);
            bds2.DataSource = dbc;
            gvLienLac.DataSource = bds2;
            Load();
        }

        
        private void BtnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new ThemNhom();
            f.ShowDialog();
            LoadNhom();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhóm này?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                NhomDanhBa a = (NhomDanhBa)bds1.Current;
                NhomDanhBa.RemoveNhom(a);
                MessageBox.Show("Đã xóa nhóm: " + a.TenNhom);
            }
            LoadNhom();
            Load();
            String n = gvNhom.CurrentRow.Cells[0].Value.ToString();

        }

        private void BtnThemll_Click(object sender, EventArgs e)
        {
            int a = 0;
            if(gvNhom.SelectedCells[0].RowIndex>0)
                a = gvNhom.SelectedCells[0].RowIndex; 
            var f = new ThemLienLac(a);
            txtSearch.Text = "";
            f.ShowDialog();
            LoadNhom();
            Load();
        }

        private void BtnXoall_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            String a = gvLienLac.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Bạn có chắc muốn xóa: "+ a,"Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                ChiTietDanhBa.Removectdb(a);
                MessageBox.Show("Đã xóa liên lạc: "+a);
            }
            LoadNhom();
            Load();
        }

       
    }
}
