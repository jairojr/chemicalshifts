using System;
using System.Collections.Generic;
using System.Text;

namespace ChemicalShifts.API.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class AcademicArticleViewModel : BaseViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Calibration { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public DateTime? PublishDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RevisedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AcceptedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Authors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ChemicalShiftViewModel> ChemicalShifts { get; set; }
    }
}
