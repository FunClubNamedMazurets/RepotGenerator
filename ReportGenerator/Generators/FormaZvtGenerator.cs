using ReportGenerator.Data.Entities;
using ReportGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Generators
{
    public class FormaZvtGenerator : BaseGenerator, IGenerator<FormaZvt>
    {
        private string Word { get; set; }

        private FormaZvtService formaZvtService;

        public FormaZvtGenerator(string path) : base(path)
        {
            formaZvtService = new FormaZvtService();

        }

        public void Generate(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(FormaZvt model)
        {
            formaZvtService.Insert(model);
        }

        public bool Validate(FormaZvt model)
        {
            if (model == null)
            {
                return false;
            }

            return true;
        }
    }
}
