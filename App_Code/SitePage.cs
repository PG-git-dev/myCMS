using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite11
{
    /// <summary>
    /// Класс html-страницы Сводное описание для SitePage
    /// </summary>
    public class SitePage
    {
        public string Name { get; set; }
        public string Favicon { get; set; }
        public int BlocksNumber { get; set; }
        public string SiteDirName { get; }

        public SitePage()
        {
            int i = 1;
            this.Name = "MySite" + i;
            SiteDirName = System.AppDomain.CurrentDomain.BaseDirectory + Name;

        }
    }
}
