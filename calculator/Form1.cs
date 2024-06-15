using calculator.Constants;
using calculator.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace calculator
{
    /**
     * 電卓アプリ(途中)　実装状況
     * - [x] 画面作成
     * - [x] 数値の入力、スタックへの格納
     * - [ ] 小数点の入力制御
     * - [ ] 途中式の表示
     * - [ ] 計算の実行
     * - [ ] 計算結果の表示
     * 
     * 実装概要
     * - 入力値を数値とコマンド(四則演算、「=」)に分類し、途中式をスタックとして保持する
     * - 計算実行のトリガーにより、途中式を評価する
     * 
     * 現状、Windows標準の電卓と挙動を合わせようとしていますが、まずは最小構成の電卓機能での実装をお願いします。
     * 以下、仕様の簡素化の方針となります。
     * 
     * - 計算実行のトリガーを「=」クリック時のみに限定する
     * - 計算実行後は保持している計算式をリセットし、結果のみ保持・表示する
     * - 四則演算「+」「-」「×」「÷」は連続して入力できないよう制御する
     * - 計算実行「=」はスタックの先頭が数値の場合のみ可能とする※スタックの先頭が四則演算の場合は計算を実行しない
     * - 四則演算および計算実行時に数値の末尾が「.」小数点の場合は「.0」で置換する
     * 
     * また、現実装では入力値をdecimal型で保持しており、「312.」のような末尾が小数点のパターンをカバーしていないため文字列かCalcInputのリストとして保持することを検討してください
     * 
     * 
     */
    public partial class Form1 : Form
    {
        private static ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private calculator.ViewModels.CalculatorViewModel viewModel = new calculator.ViewModels.CalculatorViewModel();

        public Form1()
        {
            InitializeComponent();
            // 初期化
            CalcInputEnum inputEnum = CalcInputEnum.Zero;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);

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
            Logger.Debug($"数値入力：{(decimal)inputEnum}, 途中式: {stack.ToString()}");
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
            this.textBox2.Text = this.viewModel.Stack.ToString();
        }


        private void buttonCommandEqual_Click(object sender, EventArgs e)
        {
            //CalcCommandEnum commandEnum = CalcCommandEnum.Equal;
            //var stack = this.viewModel.Stack;
            //if (stack.Count() == 0)
            //{
            //    return;
            //}
            //else
            //{
            //    var peek = stack.Peek();
            //    if (peek is CalcInput)
            //    {
            //        var latestCalcCommand = new CalcCommand(commandEnum);
            //        stack.Push(latestCalcCommand);
            //    }
            //    else if (peek is CalcCommand)
            //    {
            //        var latestCalcCommand = new CalcCommand(commandEnum);
            //        stack.Pop();
            //        stack.Push(latestCalcCommand);
            //    }
            //    else
            //    {
            //        throw new InvalidOperationException("Invalids state");
            //    }
            //}
            //this.textBox2.Text = String.Join(" ", this.viewModel.Stack.Select(v =>
            //{
            //    if (v is CalcInput)
            //    {
            //        return (v as CalcInput).GetValue().ToString();
            //    }
            //    else if (v is CalcCommand)
            //    {
            //        return (v as CalcCommand).Value.ToString();
            //    }
            //    else
            //    {
            //        throw new InvalidOperationException("Invalids state");
            //    }
            //}));

        }

        private void buttonCommandPlus_Click(object sender, EventArgs e)
        {
            CalcCommandEnum commandEnum = CalcCommandEnum.Plus;
            var stack = this.viewModel.Stack;
            if (stack.Count() == 0)
            {
                return;
            }
            else
            {
                var peek = stack.Peek();
                if (peek is CalcInput)
                {
                    var latestCalcCommand = new CalcCommand(commandEnum);
                    stack.Push(latestCalcCommand);
                }
                else if (peek is CalcCommand)
                {
                    var latestCalcCommand = new CalcCommand(commandEnum);
                    stack.Pop();
                    stack.Push(latestCalcCommand);
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
            }));

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
            CalcInputEnum inputEnum = CalcInputEnum.Zero;
            var stack = this.viewModel.Stack;
            UpdateCalculationStack(inputEnum, stack);
            this.textBox2.Text = String.Join("", this.viewModel.Stack);

        }
    }
}
