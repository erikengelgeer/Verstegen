using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class GetData
    {
        public List<Blog> getBlogs()
        {
            using (var context = new MyContext())
            {
                List<Blog> data = context.Blogs.ToList();
                return data;
            }
        }

        public List<Category> getCategorys()
        {
            using (var context = new MyContext())
            {
                List<Category> data = context.Categorys.ToList();
                return data;
            }
        }

        public Contact GetContact()
        {
            using (var context = new MyContext())
            {
                return context.Contacts.Last();
            }
        }
    }
}
