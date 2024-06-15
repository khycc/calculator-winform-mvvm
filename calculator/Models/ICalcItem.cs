namespace calculator.Models
{
    public interface ICalcItem { }
    
    public interface ICalcItem<T> : ICalcItem
    {
        T Value { get; set; }

        T GetValue();
    }
}
