using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChemicalShifts.API.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class ChemicalShiftViewModel : BaseViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Carbon6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Hydrogen6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Solvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual MonosaccharideUnitViewModel MonosaccharideUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public byte[] HSQC { get; set; }
    }
}
