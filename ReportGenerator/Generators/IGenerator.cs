using ReportGenerator.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Generators
{
    public interface IGenerator<T> where T : BaseEntity
    {
        bool Validate(T model);

        void Save(T model);

        void Generate(int id);
    }
}
