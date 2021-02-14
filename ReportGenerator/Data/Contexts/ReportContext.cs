using ReportGenerator.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Data.Contexts
{
    public class ReportContext : DbContext
    {
        public DbSet<Dodatoc2> Dodatoc2s { get; set; }

        public DbSet<FormaZvt> FormaZvts { get; set; }

        public ReportContext() : base()
        {

        }
    }
}
