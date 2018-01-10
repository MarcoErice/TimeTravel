using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTravel.Interfaces;

namespace TimeTravel.Services
{
    public class FakeTimeProvider : iTimeProvider
    {
        private DateTime _now;
        public DateTime Now { get => _now; set => _now = value; }
    }
}
