using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator.ViewModels
{
    public class CalculatorViewModel : IDisposable
    {
        public CalculatorViewModel()
        {
            // Initialize the model
            Model = new Models.Calculator();
            this.Queue = new Queue<string>();
        }

        public Models.Calculator Model { get; set; }
        public Queue<string> Queue { get; set; }

        public void Dispose()
        {
            // Clean up the model
            Model.Dispose();
        }
    }
}
