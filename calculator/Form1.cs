using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.viewModel.Queue.Enqueue("1");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }

        private void buttonInputTwo_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("2");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputThree_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("3");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputFour_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("4");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputFive_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("5");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputSix_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("6");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputSeven_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("7");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputEight_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("8");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputNine_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("9");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }
        private void buttonInputZero_Click(object sender, EventArgs e)
        {
            this.viewModel.Queue.Enqueue("0");
            this.textBox2.Text = String.Join("", this.viewModel.Queue);
        }

        private void buttonInputDot_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandCalc_Click(object sender, EventArgs e)
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
            this.viewModel.Queue.Clear();
            this.textBox2.Text = String.Join("", this.viewModel.Queue);

        }
    }
}
