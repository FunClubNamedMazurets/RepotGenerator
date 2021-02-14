using ReportGenerator.Data.Contexts;
using ReportGenerator.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Services
{
    class FormaZvtService : IBaseService<FormaZvt>
    {
        private ReportContext _reportContext;

        public FormaZvtService()
        {
            _reportContext = new ReportContext();
        }

        public void Delete(int id)
        {
            var formaZvts = _reportContext.FormaZvts.First(x => x.Id == id);

            if (formaZvts != null)
            {
                _reportContext.FormaZvts.Remove(formaZvts);
                _reportContext.SaveChanges();
            }
        }

        public IList<FormaZvt> GetAll()
        {
            return _reportContext.FormaZvts.ToList();
        }

        public FormaZvt GetById(int id)
        {
            return _reportContext.FormaZvts.Where(x => x.Id == id).First();
        }

        public void Insert(FormaZvt entity)
        {
            _reportContext.FormaZvts.Add(entity);
            _reportContext.SaveChanges();
        }

        public void Update(FormaZvt entity)
        {
            var formaZvts = _reportContext.FormaZvts.First(x => x.Id == entity.Id);
            if (formaZvts != null)
            {
                formaZvts = entity;
                _reportContext.SaveChanges();
            }
        }
    }
}
