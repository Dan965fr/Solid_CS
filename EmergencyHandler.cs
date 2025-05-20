using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        private readonly ILogger _logger;
        private readonly IEmailAlert _emailalert;

        public EmergencyHandler(ILogger logger,IEmailAlert emailAlert )
        {
            _logger = logger;
            _emailalert = emailAlert;
        }

        public void HandleEmergency()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            _logger.Log("EMERGENCY OCCURRED");
            _emailalert.SendEmail("Emergency triggered");

        }
    }
}
