using ABCNewsPaper.BusinessLogicLayer.BusinessLogicLayer;
using ABCNewsPaper.Entities.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaperPublisher
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // creating news paper object
                NewsPaperGenerator objNewsPaper = new NewsPaperGenerator();
                NewsPaper paper = objNewsPaper.GenerateNewsPaper();

                // setting console to look like news paper
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                // setting console title with date
                Console.Title = "The Times of Today (" + paper.NewsPaperDate.ToShortDateString() + ")";
                Console.WriteLine("News Paper date: " + paper.NewsPaperDate.ToShortDateString());

                foreach (var objPaper in paper.NewsPaperPages)
                {
                    Console.WriteLine("Page Number: " + objPaper.PageNumber.ToString());
                    Console.WriteLine("-----------News------------");
                    // looping in for news on a page
                    foreach (var objNews in objPaper.NewsArticle)
                    {
                        Console.WriteLine(objNews.Heading);
                        Console.WriteLine(objNews.Content);
                        Console.WriteLine("---------------------------");
                    }
                    Console.WriteLine("-----------Advertisement------------");
                    // looping in for advertisements on a page
                    foreach (var objAd in objPaper.Advertisement)
                    {
                        Console.WriteLine(objAd.Heading);
                        Console.WriteLine(objAd.Content);
                        Console.WriteLine("---------------------------");
                    }
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
