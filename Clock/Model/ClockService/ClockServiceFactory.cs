using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.ClockService {

    public static class ClockServiceFactory {

        // Threadsafe Singleton
        private static volatile IClockService _instance = null;
        private static readonly object SyncRoot = new Object();

        public static IClockService Instance {
            get {
                if (_instance == null) {
                    lock (SyncRoot) {
                        if (_instance == null) _instance = new impl.ClockService();
                    }
                }
                return _instance;
            }
        }

    }

}
