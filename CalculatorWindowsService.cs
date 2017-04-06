using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFWindowsService
{
    public class CalculatorWindowsService : ServiceBase
    {
        public ServiceHost servicehost = null;
        public CalculatorWindowsService()
        {
            // Name the Windows Service
            ServiceName = "WCFWindowsServiceTwo";
        }

        public static void Main()
        {
            ServiceBase.Run(new CalculatorWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (servicehost != null)
            {
                servicehost.Close();
            }

            servicehost = new WebServiceHost(typeof(CalculatorService));
            servicehost.Open();
        }

        protected override void OnStop()
        {
            if (servicehost != null)
            {
                servicehost.Close();
                servicehost = null;
            }
        }
    }
}
