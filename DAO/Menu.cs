using Project_Tech_News.Models.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tech_News.DAO
{
    public class MenuDAO
    {
        News_TechEntities db = null;
        public MenuDAO() 
        {
            db = new News_TechEntities();
        }
        
    }
}