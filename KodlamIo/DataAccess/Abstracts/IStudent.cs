using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Abstracts
{
    internal interface IStudent
    {
        void Create(BaseStudent baseStudent);
        void Delete(BaseStudent baseStudent);
    }
}
