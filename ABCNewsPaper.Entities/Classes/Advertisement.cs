using ABCNewsPaper.Entities.Classes.Base;
using ABCNewsPaper.Entities.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classe
{
    /// <summary>
    /// Implemented from News Base Class
    /// Class can be extended to have more properties
    /// Common properties can be added in Base Class
    /// </summary>
    public class Advertisement : NewsBase
    {
        public AdvertisementType AdType { get; set; }
    }
}
