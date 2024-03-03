using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Abstracts
{
    internal interface ITeacher
    {
        void Delete(BaseTeacher baseTeacher);
        void Create(BaseTeacher baseTeacher);
    }
}
