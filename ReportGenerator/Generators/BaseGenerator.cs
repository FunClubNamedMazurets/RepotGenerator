using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Generators
{
    public abstract class BaseGenerator
    {
        public BaseGenerator(string path)
        {
            pathForSave = path;
        }
        protected string pathForSave { get; set; }
    }
}
