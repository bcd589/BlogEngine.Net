using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Entity
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsVarified { get; set; }

        public DateTime LastLOgin { get; set; }

        public bool IsDeleted { get; set; }
    }
}
