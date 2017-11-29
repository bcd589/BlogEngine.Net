using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Entity
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Fullname
        {
            get
            {
                return Firstname + " " + LastName;
            }

            set
            {
                value = Firstname + " " + LastName;
            }
        }


        [Required]
        [NotMapped]
        public string Firstname { get; set; }
        [Required]
        [NotMapped]
        public string LastName { get; set; }

        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string Url { get; set; }

        public Login Login { get; set; }
        [ForeignKey("Login")]
        public int LoginId { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

        public DateTime DateOfBirth { get; set; }

        public User()
        {
            Blogs = new HashSet<Blog>();
        }
    }
}
