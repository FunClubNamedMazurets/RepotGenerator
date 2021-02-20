using ReportGenerator.Data.Entities;
using ReportGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Generators
{
    class Dodatoc4Generator : BaseGenerator, IGenerator<Dodatoc4>
    {
        private string Word { get; set; }

        private Dodatoc4Service dodatoc4Service;

        public Dodatoc4Generator(string path) : base(path)
        {
            dodatoc4Service = new Dodatoc4Service();

        }

        public void Generate(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Dodatoc4 model)
        {
            dodatoc4Service.Insert(model);
        }

        public bool Validate(Dodatoc4 model)
        {
            if (model == null)
            {
                return false;
            }

            return true;
        }
    }
}
