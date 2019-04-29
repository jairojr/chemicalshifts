﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime Altered { get; set; }
    }
}
