using calculator.Models;
using System;
using System.Collections.Generic;


namespace calculator.ViewModels
{
    public class CalculatorViewModel : IDisposable
    {
        public CalculatorViewModel()
        {
            // Initialize the model
            Model = new Models.Calculator();
            this.Stack = new CalculatorStack();
        }

        public Models.Calculator Model { get; set; }
        public CalculatorStack Stack { get; set; }

        public void Dispose()
        {
            // Clean up the model
            Model.Dispose();
        }
    }
}
