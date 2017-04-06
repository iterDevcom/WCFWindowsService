using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;

namespace WCFWindowsService
{
   [ServiceContract(Namespace = "http://WCFWindowsService")]
   public interface ICalculator
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        double Add(double n1, double n2);
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        double Subtract(double n1, double n2);
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        double Multiply(double n1, double n2);
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        double Divide(double n1, double n2);
    }
}
