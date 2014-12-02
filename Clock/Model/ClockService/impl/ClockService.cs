using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.ClockService.impl {

    class ClockService : IClockService {
        public DateTime GetTime() {
            return DateTime.Now;
        }
    }

}
