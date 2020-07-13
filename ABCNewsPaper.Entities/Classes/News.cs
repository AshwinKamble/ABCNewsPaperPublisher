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
    /// News class implemented from News Base class
    /// New news properties can extend this class if needed,
    /// Common properties of content are added in this class
    /// </summary>
    public class News : NewsBase
    {
        public NewsType NewsType { get; set; }

        public NewsSource NewsSource { get; set; }

        public NewsPriority NewsPriority { get; set; }
    }
}
