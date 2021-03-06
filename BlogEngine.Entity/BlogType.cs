﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Entity
{
    public class BlogType
    {
        public int Id { get; set; }

        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }

        public BlogType()
        {
            Blogs = new HashSet<Blog>();
        }
    }
}