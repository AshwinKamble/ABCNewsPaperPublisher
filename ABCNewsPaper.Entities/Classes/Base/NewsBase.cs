using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCNewsPaper.Entities.Classes.Base
{
    /// <summary>
    /// Base class for news to extend common functionality
    /// A new category can extend this class if needed
    /// Common properties of content are added in this class
    /// </summary>
    public class NewsBase
    {
        public string Heading { get; set; }

        public string Content { get; set; }
    }
}
