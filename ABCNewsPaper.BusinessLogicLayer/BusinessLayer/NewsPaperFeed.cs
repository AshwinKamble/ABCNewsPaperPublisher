using ABCNewsPaper.BusinessLogicLayer.Interface;
using ABCNewsPaper.Entities.Classe;
using ABCNewsPaper.Entities.Enumeration;
using ABCNewsPaper.SourceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.BusinessLogicLayer.BusinessLogicLayer
{
    /// <summary>
    /// Dummy class to generate random and advertisement items
    /// </summary>
    public class NewsPaperFeed : INewsPaperFeed
    {
        private NewsService newsService;

        public NewsPaperFeed()
        {
            newsService = new NewsService();
        }

        List<News> INewsPaperFeed.GetAllNewsFeeds()
        {
            try
            {
                return newsService.GetNewsFeed();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<News> INewsPaperFeed.GetSportNewsFeed()
        {
            try
            {
                return newsService.GetNewsFeed().ToList().FindAll(x => x.NewsType == NewsType.Sports);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<Advertisement> INewsPaperFeed.GetAllAdvertisementFeed()
        {
            try
            {
                return newsService.GetAdvertisementFeed().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<Advertisement> INewsPaperFeed.GetMatrimonialNewsFeed()
        {
            try
            {
                return newsService.GetAdvertisementFeed().FindAll(x => x.AdType == AdvertisementType.Matrimonial).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<Advertisement> INewsPaperFeed.GetPublicNoticesNewsFeed()
        {
            try
            {
                return newsService.GetAdvertisementFeed().FindAll(x => x.AdType == AdvertisementType.PublicNotices).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
