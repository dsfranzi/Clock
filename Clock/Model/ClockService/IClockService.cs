using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.ClockService {

    public interface IClockService {
        DateTime GetTime();
    }

}
