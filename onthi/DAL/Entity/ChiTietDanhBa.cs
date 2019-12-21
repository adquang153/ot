using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi.DAL.Entity
{
    class ChiTietDanhBa
    {
        [Key]
        public String TenGoi { get; set; }
        public String Email { get; set; }
        public String SDT { get; set; }
        public String DiaChi { get; set; }
        public String TenNhom { get; set; }
        [ForeignKey("TenNhom")]
        public virtual NhomDanhBa NhomDanhBa { get; set; }

        public static List<ChiTietDanhBa> GetFromCTDB(String ndb)
        {
            List<ChiTietDanhBa> dsctdb = new KetNoiDBContext().ChiTietDanhBaDbSet.ToList();
            List<ChiTietDanhBa> a = new List<ChiTietDanhBa>();
            foreach(ChiTietDanhBa i in dsctdb)
            {
                if (i.TenNhom.Equals(ndb))
                    a.Add(i);
            }
            return a;
        }

        public static void Addctdb(ChiTietDanhBa ct)
        {
            var db = new KetNoiDBContext();
            db.ChiTietDanhBaDbSet.Add(ct);
            try {
                db.SaveChanges();
                MessageBox.Show("Đã thêm liên lạc " + ct.TenGoi);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Liên lạc " + ct.TenGoi+" Đã tồn tại");
            }
        }
        public static void Removectdb(String tenll)
        {
            var db = new KetNoiDBContext();
            var obj = db.ChiTietDanhBaDbSet.Where(e => e.TenGoi == tenll).FirstOrDefault();
            if (obj != null)
                db.ChiTietDanhBaDbSet.Remove(obj);
            db.SaveChanges();
        }
    }
}
