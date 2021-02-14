using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Data.Entities
{
    public class FormaZvt : BaseEntity
    {
        //назва організації профспілки
        public string NameOfGuild { get; set; }

        //за 20____ рік дві останні цифри
        public string Year { get; set; }

        //Технічних (головних технічних) інспекторів праці, всього:
        public string NumberTechnicalInspectors { get; set; }

        //Технічний інспектор праці
        public string TechnicalInspector { get; set; }

        public class Grid
        {

            //Кількість за періоди звітний
            public string Column3 { get; set; }

            //Кількість за періоди попередній
            public string Column4 { get; set; }

        }


    }
}
