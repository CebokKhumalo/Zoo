using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Authorization.Users;
using Zoo.Domain.Enum;

namespace Zoo.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual RefListGender? Gender { get; set; }
        public virtual string FirstDateOfEmployment { get; set; }
        public virtual string LastDateOfEmployment { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Password { get; set; }
        public User User { get; set; }

        [NotMapped]
        public virtual string[] RoleNames { get; set; }
    }
}
