using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Entity
{
    public class BlogCatagory
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Url { get; set; }

        public string Destription { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }


        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }

        public BlogCatagory()
        {
            Blogs = new HashSet<Blog>();
        }
    }
}
