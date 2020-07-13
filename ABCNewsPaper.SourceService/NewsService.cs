using ABCNewsPaper.Entities.Classe;
using ABCNewsPaper.Entities.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.SourceService
{
    public class NewsService
    {
        public List<News> GetNewsFeed()
        {
            List<News> lstNews = new List<News>()
            {
                new News
                {
                    Content = "Amitabh Bachchan is currently admitted in Nanavati hospital’s isolation ward after he and three of his family members tested positive for Covid-19 on Saturday. However, the 77-year-old didn’t abandon his daily routine of wishing members of his ‘extended family’ on their birthdays. Keeping up with the tradition, the Gulabo Sitabo actor wrote a short blog entry on Sunday night.",
                    Heading = "Amitabh Bachchan keeps up with his routine in isolation ward",
                    NewsType = NewsType.Entertainment,
                    NewsPriority = NewsPriority.High,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "Fast bowler Gabriel was named man-of-the-match after taking combined figures of nine wickets for 137 runs as international cricket returned from lockdown.",
                    Heading = "1st Test: Holder hails Gabriel's 'massive heart' as Windies beat England",
                    NewsType = NewsType.Sports,
                    NewsPriority = NewsPriority.High,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "Speaking after the win at the post-match presentation ceremony, Holder said: One of our best victories. Yesterday was the best day I had in Test cricket. West Indies captain Jason Holder hailed the win over England in the first Test in Southampton as one of the best ones picked by the team",
                    Heading = "West Indies captain Jason Holder after win over England in Southampton",
                    NewsType = NewsType.Sports,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "A major dispute has arisen between the ruling Congress and the Opposition BJP in Rajasthan, with Chief Minister Ashok Gehlot once again accusing the latter of trying to topple his government in the midst of the COVID-19 pandemic. Mr. Gehlot said on Saturday that though huge sums of money were being offered to the Congress MLAs, his government was stable and would complete its term.",
                    Heading = "Rajasthan political crisis: An I-T raid at the time of CLP meeting raises eyebrows",
                    NewsType = NewsType.Political,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "If Florida were a country, it would rank fourth in the world for the most new cases in a day behind the United States, Brazil and India, according to a Reuters analysis.",
                    Heading = "Florida Sets 1-Day Record Of New COVID-19 Cases, More Than Most Countries",
                    NewsType = NewsType.Sports,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "Four months after 22 Congress legislators defected to the BJP and brought down the Kamal Nath government in Madhya Pradesh, one more Congress MLA joined the saffron party on Sunday, dealing another blow to the Opposition party ahead of the crucial by-elections.",
                    Heading = "Another MP Congress MLA joins BJP, gets minister status",
                    NewsType = NewsType.Political,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "President Ibrahim Mohamed Solih has announced that Maldives will re-open its borders for international tourists on July 15th. Resorts, liveaboards and hotels located on uninhabited islands will be allowed to resume business.",
                    Heading = "Maldives to fully reopen to tourism in August",
                    NewsType = NewsType.Travel,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "The Sechenov First Moscow State Medical University began clinical trials of the vaccine produced by Russia's Gamalei Institute of Epidemiology and Microbiology on June 18.",
                    Heading = "Russian University Claims Successful Trials Of 1st Covid Vaccine",
                    NewsType = NewsType.Health,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "A newly discovered comet is streaking past Earth, providing a stunning nighttime show after buzzing the sun and expanding its tail. The comet will be visible in India from July 14 onwards as it soars across the solar system.",
                    Heading = "Comet Neowise to be visible in Indian skies for 20 days starting July 14",
                    NewsType = NewsType.Science,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.External
                },
                new News
                {
                    Content = "Perseverance's mission is far more ambitious than previous rover trips to Mars. This endeavor will not only examine conditions that might have made the planet habitable in the past but also look for signs of microbes that might have lived there.",
                    Heading = "Mars Rover Perseverance Rolls Closer To Summer Launch",
                    NewsType = NewsType.Science,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.Internal
                },
                new News
                {
                    Content = "Dr Randeep Guleria, who heads the clinical research group of the national Covid-19 task force, said that medical examination of patients with severe illness showed that even months after recovery, their lungs continued to be in bad shape.",
                    Heading = "Evidence of immunity is a glimmer, but data show lasting Covid-19 damage",
                    NewsType = NewsType.Health,
                    NewsPriority = NewsPriority.Moderate,
                    NewsSource = NewsSource.Internal
                }
            };
            return lstNews;
        }

        public List<Advertisement> GetAdvertisementFeed()
        {
            List<Advertisement> lstAdv = new List<Advertisement>()
            {
                new Advertisement
                {
                    Content = "Book a flat in lockdown in just 85 lacs*, contact us for more details.",
                    Heading = "Now it is right time to book at Rustomji",
                    AdType = AdvertisementType.Property
                },
                new Advertisement
                {
                    Content = "Enroll now! For free session on training and certificatio.",
                    Heading = "Java, J2EE with certification",
                    AdType = AdvertisementType.Educational
                },
                new Advertisement
                {
                    Content = "Tender for building shopping complex near Gudgaon on 2 acers area is open now.",
                    Heading = "Submit you tender coatation before month end",
                    AdType = AdvertisementType.Tender
                }
                ,
                new Advertisement
                {
                    Content = "Looking for well settled, caring and good family background partner.",
                    Heading = "28 year old groom looking for perfect partener.",
                    AdType = AdvertisementType.Matrimonial
                },
                new Advertisement
                {
                    Content = "Notive is hereby given that a meeting of Board of directors of the company will be held on end of this month.",
                    Heading = "Anshika pvt. ltd. Board of directors meeting",
                    AdType = AdvertisementType.PublicNotices
                },
                new Advertisement
                {
                    Content = "Self-motivated and passionate teachers are needed for a high quality English medium school in Mumbai.",
                    Heading = "Teachers rquired - ABC Coaching",
                    AdType = AdvertisementType.Educational
                }
            };
            return lstAdv;
        }
    }
}
