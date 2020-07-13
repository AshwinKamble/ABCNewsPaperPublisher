using ABCNewsPaper.Entities.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.BusinessLogicLayer.Interface
{
    /// <summary>
    /// Interface to extend news paper feed class which can be extended to have multiple sources of news
    /// </summary>
    public interface INewsPaperFeed
    {
        List<News> GetAllNewsFeeds();

        /// <summary>
        /// Added to get specific sports related news, news paper need to have a separate news page all together
        /// </summary>
        /// <returns></returns>
        List<News> GetSportNewsFeed();

        List<Advertisement> GetMatrimonialNewsFeed();

        List<Advertisement> GetPublicNoticesNewsFeed();

        List<Advertisement> GetAllAdvertisementFeed();
    }
}
