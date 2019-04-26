using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.ViewModel
{
    public class BaseViewModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Altered { get; set; }
    }
}
