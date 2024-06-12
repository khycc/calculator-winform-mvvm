using calculator.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Models
{
    internal class CalcCommand : ICalcItem<CalcCommandEnum>
    {
        public CalcCommandEnum Value { get; set; }

        public CalcCommandEnum GetValue()
        {
            return (this as ICalcItem<CalcCommandEnum>).Value;
        }
    }
}
