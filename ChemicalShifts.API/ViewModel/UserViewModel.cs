using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ChemicalShifts.Domain.Enums.Enums;

namespace ChemicalShifts.API.ViewModel
{
    public class UserViewModel: BaseViewModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public EnumUserType UserType { get; set; }
    }
}
