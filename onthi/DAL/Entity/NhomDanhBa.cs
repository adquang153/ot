using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi.DAL.Entity
{
    class NhomDanhBa
    {
        [Key]
        public String TenNhom { get; set; }
        public static List<NhomDanhBa> GetFromNDB()
        {
            return new KetNoiDBContext().NhomDanhBaDbSet.ToList();
        }
        public static void Add(NhomDanhBa tn)
        {
            var db = new KetNoiDBContext();
            db.NhomDanhBaDbSet.Add(tn);
            db.SaveChanges();
        }
        public static void RemoveNhom(NhomDanhBa a)
        {
            var db = new KetNoiDBContext();
            var obj = db.NhomDanhBaDbSet.Where(e => e.TenNhom == a.TenNhom).FirstOrDefault();
            if (obj != null)
                db.NhomDanhBaDbSet.Remove(obj);
            db.SaveChanges();
        }
    }
}
