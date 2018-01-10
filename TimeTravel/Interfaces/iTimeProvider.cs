using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTravel.Interfaces
{
    public interface iTimeProvider
    {
        DateTime Now { get; set; }
    }
}
