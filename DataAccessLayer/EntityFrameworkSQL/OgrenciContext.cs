using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworkSQL
{
    public class OgrenciContext:DbContext
    {
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
    }
}
