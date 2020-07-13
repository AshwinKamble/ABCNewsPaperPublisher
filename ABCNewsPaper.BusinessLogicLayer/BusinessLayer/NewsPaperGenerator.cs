using ABCNewsPaper.BusinessLogicLayer.BusinessHelper;
using ABCNewsPaper.Entities.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.BusinessLogicLayer.BusinessLogicLayer
{
    /// <summary>
    /// News paper generator class to create object of news paper and to return news paper with news and advertisements
    /// </summary>
    public class NewsPaperGenerator
    {
        private PaperGeneraterHelper helper;

        public NewsPaper GenerateNewsPaper()
        {
            try
            {
                NewsPaper objPaper = NewsPaper.GetInstance(DateTime.Now);

                NewsPaperPage objPage = new NewsPaperPage();
                objPaper.NewsPaperPages.Add(objPage);

                helper = new PaperGeneraterHelper();
                helper.AddPagesToNewsPaper(objPaper, objPage);
                helper.AddAddvertisementToNewsPaper(objPaper);

                return objPaper;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
