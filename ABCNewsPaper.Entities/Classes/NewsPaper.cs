
using ABCNewsPaper.Entities.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classe
{
    /// <summary>
    /// Creating NewsPaper class a singleton to showcase only one news paper object will be created on a given day
    /// </summary>
    public class NewsPaper : NewsPaperBase
    {
        private static NewsPaper _instace;
        private static List<DateTime> _lstPaperDates = new List<DateTime>();

        public NewsPaper(DateTime _dt)
        {
            this.NewsPaperDate = _dt;
        }

        /// <summary>
        /// Method to retuen news paper instance
        /// List of dates is an extra check added to generate news paper for 1 or 2 days in future
        /// When configuring news paper for future date, this function will always return one instance for that date
        /// </summary>
        /// <param name="_dt"></param>
        /// <returns></returns>
        public static NewsPaper GetInstance(DateTime _dt)
        {
            if (!_lstPaperDates.Contains(_dt))
            {
                _instace = new NewsPaper(_dt);
                _lstPaperDates.Add(_dt);
            }
            return _instace;
        }
    }
}
