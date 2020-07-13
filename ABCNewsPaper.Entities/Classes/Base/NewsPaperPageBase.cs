using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classes.Base
{
    /// <summary>
    /// Abstract class has been created to extend the News Paper page class to have more functionalities
    /// </summary>
    public abstract class NewsPaperPageBase
    {
        public int PageNumber { get; set; }

        /// <summary>
        /// For example abstract method has been added which can be implemented as per need in derived class
        /// </summary>
        /// <returns></returns>
        public abstract string GetPageNumber();
    }
}
