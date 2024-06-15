using calculator.Constants;

namespace calculator.Models
{
    internal class CalcCommand : ICalcItem<CalcCommandEnum>
    {
        public CalcCommandEnum Value { get; set; }

        public CalcCommandEnum GetValue()
        {
            return (this as ICalcItem<CalcCommandEnum>).Value;
        }

        public CalcCommand(CalcCommandEnum value)
        {
            this.Value = value;
        }
    }
}
