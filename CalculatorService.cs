
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Activation;
using System.IO;

namespace WCFWindowsService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CalculatorService : ICalculator
    {
        public double Add(double n1, double n2)
        {
            string str = System.DateTime.Now.ToString();
            StreamWriter write = new StreamWriter("c:\\test1.txt"); 
            write.WriteLine(str);
            write.Close();
            double result = n1 + n2;
            return result;
        }

        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }

        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            return result;
        }

        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
    }
}
