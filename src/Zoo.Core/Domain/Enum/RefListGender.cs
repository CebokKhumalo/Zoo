using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Domain.Enum
{
    public enum RefListGender: int
    {

        [Description("Male")]
        male = 1,
        [Description("Female")]
        female = 2,
    }
}
