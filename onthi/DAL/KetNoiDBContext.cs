using onthi.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi.DAL
{
    class KetNoiDBContext:DbContext
    {
        public KetNoiDBContext(): base("Data Source=.;Initial Catalog=OnThiDB;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<NhomDanhBa> NhomDanhBaDbSet { get; set; } 
        public DbSet<ChiTietDanhBa> ChiTietDanhBaDbSet { get; set; }
    }
}
