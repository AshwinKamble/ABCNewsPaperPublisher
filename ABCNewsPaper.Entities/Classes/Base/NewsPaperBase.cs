using ABCNewsPaper.Entities.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classes.Base
{
    /// <summary>
    /// Created absract class for NewsPaper, so that the class is scalable to add more properties/methods to it and can be overrirden
    /// </summary>
    public abstract class NewsPaperBase
    {
        public NewsPaperBase()
        {
            NewsPaperPages = new List<NewsPaperPage>();
        }

        public DateTime NewsPaperDate { get; set; }

        public List<NewsPaperPage> NewsPaperPages { get; set; }

        // Following methods can be exteded to have independent Sports and Advertisement page
        public bool IsSportsPageIndependent { get; set; }

        public bool IsAdvertiseIndependent { get; set; }
    }
}
