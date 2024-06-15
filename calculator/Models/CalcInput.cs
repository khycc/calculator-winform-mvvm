using calculator.Constants;

namespace calculator.Models
{
    /// <summary>
    /// 計算機の入力数値を表すクラス
    /// </summary>
    internal class CalcInput : ICalcItem<decimal>
    {
        decimal ICalcItem<decimal>.Value { get; set; }

        public decimal GetValue()
        {
            return (this as ICalcItem<decimal>).Value;
        }

        public CalcInput(decimal value)
        {
            (this as ICalcItem<decimal>).Value = value;
        }
        public CalcInput(CalcInputEnum enumValue)
        {
            (this as ICalcItem<decimal>).Value = decimal.Parse($"{((decimal)enumValue)}");
            //this.va
        }
        public CalcInput(CalcInput mergeTarget, CalcInputEnum enumValue)
        {
            var latestCalcInput = mergeTarget as CalcInput;
            var latestValue = latestCalcInput.GetValue();
            var updatedValue = decimal.Parse($"{latestValue.ToString()}{((decimal)enumValue)}");
            (this as ICalcItem<decimal>).Value = updatedValue;
        }
    }
}
