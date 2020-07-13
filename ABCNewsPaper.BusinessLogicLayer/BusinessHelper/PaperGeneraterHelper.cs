
using ABCNewsPaper.BusinessLogicLayer.BusinessLogicLayer;
using ABCNewsPaper.BusinessLogicLayer.Interface;
using ABCNewsPaper.Entities.Classe;
using ABCNewsPaper.Entities.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.BusinessLogicLayer.BusinessHelper
{
    /// <summary>
    /// Helper class to generate news paper
    /// Class has methods to create news and advertisements
    /// </summary>
    public class PaperGeneraterHelper : NewsPaperGenerator
    {
        public INewsPaperFeed objPaperFeed { get; set; }
        public IEnumerable<News> lstNews { get; set; }
        public List<Advertisement> lstAdvertise { get; set; }

        // Constants
        public const int MAX_NEWS_PER_PAGE = 3;
        public const int MAX_AD_PER_PAGE = 2;
        public const int MAX_CONTENT_PER_PAGE = 5;

        public PaperGeneraterHelper()
        {
            objPaperFeed = new NewsPaperFeed();

            this.lstNews = objPaperFeed.GetAllNewsFeeds().OrderBy(x => x.NewsSource);
            this.lstAdvertise = objPaperFeed.GetAllAdvertisementFeed();
        }

        /// <summary>
        /// Create news paper pages with news items
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="page"></param>
        public void AddPagesToNewsPaper(NewsPaper paper, NewsPaperPage page)
        {
            try
            {
                int pageCounter = 1;
                if (this.lstNews == null || this.lstNews.Count() == 0)
                {
                    throw new Exception("No content for news papaer");
                }

                foreach (var objNews in lstNews)
                {
                    page.PageNumber = pageCounter;
                    if (!IsPageHasPlaceForNews(page))
                    {
                        pageCounter++;
                        page = new NewsPaperPage();
                        page.PageNumber = pageCounter;
                        paper.NewsPaperPages.Add(page);
                    }
                    if (page.NewsArticle.Count >= MAX_NEWS_PER_PAGE)  // Check if all news items are placed
                    {
                        if (objNews.NewsPriority == NewsPriority.High)    // Check if any High priority news is still present to be added
                        {
                            page.NewsArticle.Add(objNews);
                        }
                        else
                        {
                            pageCounter++;
                            page = new NewsPaperPage();
                            page.PageNumber = pageCounter;
                            paper.NewsPaperPages.Add(page);
                            page.NewsArticle.Add(objNews);
                        }
                    }
                    else if (page.NewsArticle.Count < MAX_NEWS_PER_PAGE)
                    {
                        page.NewsArticle.Add(objNews);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Place advertisement wherever it can be added
        /// </summary>
        /// <param name="paper"></param>
        public void AddAddvertisementToNewsPaper(NewsPaper paper)
        {
            try
            {
                int adCounter = 0;
                foreach (var page in paper.NewsPaperPages)
                {
                    int newsCount = page.NewsArticle.Count;
                    int advCount = page.Advertisement.Count;

                    if (IsPageHasPlaceForNews(page))
                    {
                        int AdCountToPush = MAX_CONTENT_PER_PAGE - (newsCount + advCount);
                        if (AdCountToPush > 0)
                        {
                            page.Advertisement.AddRange(lstAdvertise.Where((value, index) => index >= adCounter && index < (adCounter + MAX_AD_PER_PAGE)).ToList());
                            adCounter = adCounter + MAX_AD_PER_PAGE;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Check if page has place for news/advertisement
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private bool IsPageHasPlaceForNews(NewsPaperPage page)
        {
            int newsCount = page.NewsArticle.Count;
            int advCount = page.Advertisement.Count;

            if (newsCount + advCount > 4)
                return false;
            return true;
        }
    }
}
