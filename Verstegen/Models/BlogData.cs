using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class BlogData
    {
        public List<Blog> getBlogs()
        {
            using (var context = new MyContext())
            {
                if(!context.Blogs.Any())
                {
                    context.Add(new Blog { Title = "Title", Text = "Dit is de text", Date = DateTime.Now });
                }

                List<Blog> data = context.Blogs.ToList();
                return data;
            }
        }
    }
}
