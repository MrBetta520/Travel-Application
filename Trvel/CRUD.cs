using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog;

namespace Trvel
{
    interface CRUD
    {
        void AddUser(UserRegistration obj);
        bool MatchedPassword(string password, string userName);
        void AddBlog(BlogInfo obj);
        List<BlogInfo> ShowBlogs();
    }

    class TravelRepository : CRUD
    {
        TravelDBEntities entities;                 // representing db

        public TravelRepository()                  // constructor
        {
            entities = new TravelDBEntities();
        }

        public void AddBlog(BlogInfo obj)          // This method is used to creating a new blog
        {
            entities.BlogInfoes.Add(obj);
            entities.SaveChanges();
        }

        public void AddUser(UserRegistration obj)  // This method is used to add new user into DB
        {
            entities.UserRegistrations.Add(obj);
            entities.SaveChanges();
        }

        public bool MatchedPassword(string password, string userName)    // This method is used to match the user name and password
        {
            var result = from psd in entities.UserRegistrations
                         where (psd.UserPassword == password && psd.UserName == userName)
                         select psd;
            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<BlogInfo> ShowBlogs()          // This method is used to return a list of existing blogs
        {
            var result = entities.BlogInfoes.ToList();
            return result;
        }
    }
}
