using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class SystemHandler
    {
        private readonly EmergencyHandler _emergencyHandler;
        private readonly RocketLauncher _rocketLauncher;

        public SystemHandler()
        {
            //ILogger logger = new FileLogger();
            ILogger logger = new DatabaseLogger();

            IEmailAlert emailAlert = new EmailAlert();
            _rocketLauncher = new RocketLauncher();

            _emergencyHandler = new EmergencyHandler(logger, emailAlert);
        }
        public void HandlerEmergency()
        {
            _emergencyHandler.HandleEmergency();
            
        }
        public void Rocket()
        {
            _rocketLauncher.Lunch();
        }
    }
}
