using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Member
    /// </summary>
    public class Member
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordSeed { get; set; }

        public string PasswordHash { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
