using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ChemicalShifts.Domain.Enums.Enums;

namespace ChemicalShifts.API.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class UserViewModel: BaseViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public EnumUserType UserType { get; set; }
    }
}
