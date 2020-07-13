using ABCNewsPaper.Entities.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classe
{
    /// <summary>
    /// News paper page class implemented from News paper base
    /// Properties to have list of News Artivle and Advertisements
    /// </summary>
    public class NewsPaperPage : NewsPaperPageBase
    {
        public List<News> NewsArticle;
        public List<Advertisement> Advertisement;

        public NewsPaperPage()
        {
            this.NewsArticle = new List<News>();
            this.Advertisement = new List<Advertisement>();
        }

        public override string GetPageNumber()
        {
            // Method to extend new page number if needed in future, hence kep empty
            // This method can be extend to have different formt of page number to display on each page
            throw new NotImplementedException();
        }
    }
}
