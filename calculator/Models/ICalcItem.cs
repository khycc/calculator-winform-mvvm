using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Models
{
    public interface ICalcItem { }
    
    public interface ICalcItem<T> : ICalcItem
    {
        T Value { get; set; }

        T GetValue();
        //{
        //    return Value;
        //}
    }
}
