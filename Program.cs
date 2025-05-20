using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            IEmailAlert emailAlert = new EmailAlert();

            EmergencyHandler emergencyHandler = new EmergencyHandler(logger, emailAlert);
            RocketLauncher rocketLauncher = new RocketLauncher();
            TelemetrySender telemetrySender = new TelemetrySender();

            
            rocketLauncher.Lunch();
            telemetrySender.Send();
            emergencyHandler.HandleEmergency();
        }

    }
    
}
