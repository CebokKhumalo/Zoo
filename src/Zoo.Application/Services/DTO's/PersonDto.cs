using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Domain.Enum;

namespace Zoo.Services.DTO_s
{
    [AutoMap(typeof(PersonDto))]
    public class PersonDto : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 
        /// </summary> 
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RefListGender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GenderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstDateOfEmployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastDateOfEmployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

    }
}
