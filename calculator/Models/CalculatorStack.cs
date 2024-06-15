using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Models
{
    public class CalculatorStack : Stack<ICalcItem>
    {
        private static ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override string ToString()
        {
            return String.Join(" ", this.Select(v =>
            {
                if (v is CalcInput)
                {
                    return (v as CalcInput).GetValue().ToString();
                }
                else if (v is CalcCommand)
                {
                    return (v as CalcCommand).Value.ToString();
                }
                else
                {
                    Logger.Warn($"Item is not supported. {v}:{v.GetType()}");
                    return string.Empty;
                }
            }));
        }
    }
}
