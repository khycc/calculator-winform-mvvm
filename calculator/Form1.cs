using calculator.Constants;
using calculator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private calculator.ViewModels.CalculatorViewModel viewModel = new calculator.ViewModels.CalculatorViewModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInputOne_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.One;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }

        private void buttonInputTwo_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Two;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputThree_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Three;
            var stack = this.viewModel.Stack;
            var peek = stack.Peek();
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputFour_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Four;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputFive_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Five;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputSix_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Six;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputSeven_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Seven;
            var stack = this.viewModel.Stack;
            var peek = stack.Peek();
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputEight_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Eight;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputNine_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Nine;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }
        private void buttonInputZero_Click(object sender, EventArgs e)
        {
            CalcInputEnum inputEnum = CalcInputEnum.Zero;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
        }

        private void buttonInputDot_Click(object sender, EventArgs e)
        {
            // CalcInput での値の保持の考慮が漏れているため小数点入力の実装が未完了です。
            // CalcInput の実装対応後に本処理を実装してください。
            // ★詳細
            // Windows の電卓の場合、コマンド発火時に小数点が評価される
            // そのため Stack には入力値(=文字列)を保持し、ViewModel側で評価値(=数値)に変換する必要がある
            // dot が入力数値の末端にある場合は入力値と評価値の文字列表現が異なるため上記考慮を適用する必要がある
            // ex)
            // 入力値：34.
            // 評価値：34
        }

        private void UpdateCalculationStack(CalcInputEnum inputEnum, Stack<ICalcItem> stack)
        {
            if (stack.Count() == 0)
            {
                var newCalcInput = new CalcInput(inputEnum);
                stack.Push(newCalcInput);
            }
            else
            {
                var peek = stack.Peek();
                if (peek is CalcInput)
                {
                    var latestCalcInput = peek as CalcInput;
                    var updatedCalcInput = new CalcInput(latestCalcInput, inputEnum);
                    stack.Pop();
                    stack.Push(updatedCalcInput);
                }
                else if (peek is CalcCommand)
                {
                    var newCalcInput = new CalcInput(inputEnum);
                    stack.Push(newCalcInput);
                }
                else
                {
                    throw new InvalidOperationException("Invalids state");
                }
            }
            this.textBox2.Text = String.Join(" ", this.viewModel.Stack.Select(v =>
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
                    throw new InvalidOperationException("Invalids state");
                }
            }
                ));
        }


        private void buttonCommandEqual_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandMultiple_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandClear_Click(object sender, EventArgs e)
        {
            this.viewModel.Stack.Clear();
            this.textBox2.Text = String.Join("", this.viewModel.Stack);

        }
    }
}
