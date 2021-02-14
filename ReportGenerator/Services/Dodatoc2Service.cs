using ReportGenerator.Data.Contexts;
using ReportGenerator.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Services
{
    public class Dodatoc2Service
    {
        private ReportContext reportContext;

        public Dodatoc2Service()
        {
            reportContext = new ReportContext();
        }

        public Dodatoc2 GetById(int id) 
        {
            return reportContext.Dodatoc2s.Where(x => x.Id == id).First();
        }

        public List<Dodatoc2> GetAll()
        {
            return reportContext.Dodatoc2s.ToList();
        }

        public void Insert(Dodatoc2 entity)
        {
            reportContext.Dodatoc2s.Add(entity);
            reportContext.SaveChanges();
        }
    }
}
