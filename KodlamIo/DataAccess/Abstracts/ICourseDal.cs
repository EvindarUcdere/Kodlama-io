using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Abstracts
{
    internal interface ICourseDal
    {
        

        void Add(ICourseDal courseDal);
        void Delete(ICourseDal courseDal);
        void Update(ICourseDal courseDal);
    }
}
