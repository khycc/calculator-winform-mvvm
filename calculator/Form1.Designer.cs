namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCommandClear = new calculator.Controls.ButtonEx();
            this.buttonInputDot = new calculator.Controls.ButtonEx();
            this.buttonCommandDivide = new calculator.Controls.ButtonEx();
            this.buttonCommandMultiple = new calculator.Controls.ButtonEx();
            this.buttonCommandMinus = new calculator.Controls.ButtonEx();
            this.buttonCommandPlus = new calculator.Controls.ButtonEx();
            this.buttonCommandEqual = new calculator.Controls.ButtonEx();
            this.buttonInputNine = new calculator.Controls.ButtonEx();
            this.buttonInputEight = new calculator.Controls.ButtonEx();
            this.buttonInputSeven = new calculator.Controls.ButtonEx();
            this.buttonInputSix = new calculator.Controls.ButtonEx();
            this.buttonInputFive = new calculator.Controls.ButtonEx();
            this.buttonInputFour = new calculator.Controls.ButtonEx();
            this.buttonInputThree = new calculator.Controls.ButtonEx();
            this.buttonInputTwo = new calculator.Controls.ButtonEx();
            this.buttonInputZero = new calculator.Controls.ButtonEx();
            this.buttonInputOne = new calculator.Controls.ButtonEx();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(457, 55);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCommandClear
            // 
            this.buttonCommandClear.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandClear.Location = new System.Drawing.Point(233, 65);
            this.buttonCommandClear.Name = "buttonCommandClear";
            this.buttonCommandClear.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandClear.TabIndex = 18;
            this.buttonCommandClear.Text = "C";
            this.buttonCommandClear.UseVisualStyleBackColor = true;
            this.buttonCommandClear.表示文字列 = "C";
            this.buttonCommandClear.Click += new System.EventHandler(this.buttonCommandClear_Click);
            // 
            // buttonInputDot
            // 
            this.buttonInputDot.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputDot.Location = new System.Drawing.Point(233, 401);
            this.buttonInputDot.Name = "buttonInputDot";
            this.buttonInputDot.Size = new System.Drawing.Size(107, 78);
            this.buttonInputDot.TabIndex = 17;
            this.buttonInputDot.Text = ".";
            this.buttonInputDot.UseVisualStyleBackColor = true;
            this.buttonInputDot.表示文字列 = ".";
            this.buttonInputDot.Click += new System.EventHandler(this.buttonInputDot_Click);
            // 
            // buttonCommandDivide
            // 
            this.buttonCommandDivide.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandDivide.Location = new System.Drawing.Point(346, 65);
            this.buttonCommandDivide.Name = "buttonCommandDivide";
            this.buttonCommandDivide.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandDivide.TabIndex = 16;
            this.buttonCommandDivide.Text = "÷";
            this.buttonCommandDivide.UseVisualStyleBackColor = true;
            this.buttonCommandDivide.表示文字列 = "÷";
            this.buttonCommandDivide.Click += new System.EventHandler(this.buttonCommandDivide_Click);
            // 
            // buttonCommandMultiple
            // 
            this.buttonCommandMultiple.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandMultiple.Location = new System.Drawing.Point(346, 149);
            this.buttonCommandMultiple.Name = "buttonCommandMultiple";
            this.buttonCommandMultiple.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandMultiple.TabIndex = 15;
            this.buttonCommandMultiple.Text = "×";
            this.buttonCommandMultiple.UseVisualStyleBackColor = true;
            this.buttonCommandMultiple.表示文字列 = "×";
            this.buttonCommandMultiple.Click += new System.EventHandler(this.buttonCommandMultiple_Click);
            // 
            // buttonCommandMinus
            // 
            this.buttonCommandMinus.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandMinus.Location = new System.Drawing.Point(346, 233);
            this.buttonCommandMinus.Name = "buttonCommandMinus";
            this.buttonCommandMinus.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandMinus.TabIndex = 14;
            this.buttonCommandMinus.Text = "-";
            this.buttonCommandMinus.UseVisualStyleBackColor = true;
            this.buttonCommandMinus.表示文字列 = "-";
            this.buttonCommandMinus.Click += new System.EventHandler(this.buttonCommandMinus_Click);
            // 
            // buttonCommandPlus
            // 
            this.buttonCommandPlus.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandPlus.Location = new System.Drawing.Point(346, 317);
            this.buttonCommandPlus.Name = "buttonCommandPlus";
            this.buttonCommandPlus.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandPlus.TabIndex = 13;
            this.buttonCommandPlus.Text = "+";
            this.buttonCommandPlus.UseVisualStyleBackColor = true;
            this.buttonCommandPlus.表示文字列 = "+";
            this.buttonCommandPlus.Click += new System.EventHandler(this.buttonCommandPlus_Click);
            // 
            // buttonCommandEqual
            // 
            this.buttonCommandEqual.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCommandEqual.Location = new System.Drawing.Point(346, 401);
            this.buttonCommandEqual.Name = "buttonCommandEqual";
            this.buttonCommandEqual.Size = new System.Drawing.Size(107, 78);
            this.buttonCommandEqual.TabIndex = 12;
            this.buttonCommandEqual.Text = "=";
            this.buttonCommandEqual.UseVisualStyleBackColor = true;
            this.buttonCommandEqual.表示文字列 = "=";
            this.buttonCommandEqual.Click += new System.EventHandler(this.buttonCommandEqual_Click);
            // 
            // buttonInputNine
            // 
            this.buttonInputNine.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputNine.Location = new System.Drawing.Point(229, 149);
            this.buttonInputNine.Name = "buttonInputNine";
            this.buttonInputNine.Size = new System.Drawing.Size(107, 78);
            this.buttonInputNine.TabIndex = 11;
            this.buttonInputNine.Text = "9";
            this.buttonInputNine.UseVisualStyleBackColor = true;
            this.buttonInputNine.表示文字列 = "9";
            this.buttonInputNine.Click += new System.EventHandler(this.buttonInputNine_Click);
            // 
            // buttonInputEight
            // 
            this.buttonInputEight.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputEight.Location = new System.Drawing.Point(116, 149);
            this.buttonInputEight.Name = "buttonInputEight";
            this.buttonInputEight.Size = new System.Drawing.Size(107, 78);
            this.buttonInputEight.TabIndex = 10;
            this.buttonInputEight.Text = "8";
            this.buttonInputEight.UseVisualStyleBackColor = true;
            this.buttonInputEight.表示文字列 = "8";
            this.buttonInputEight.Click += new System.EventHandler(this.buttonInputEight_Click);
            // 
            // buttonInputSeven
            // 
            this.buttonInputSeven.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputSeven.Location = new System.Drawing.Point(3, 149);
            this.buttonInputSeven.Name = "buttonInputSeven";
            this.buttonInputSeven.Size = new System.Drawing.Size(107, 78);
            this.buttonInputSeven.TabIndex = 9;
            this.buttonInputSeven.Text = "7";
            this.buttonInputSeven.UseVisualStyleBackColor = true;
            this.buttonInputSeven.表示文字列 = "7";
            this.buttonInputSeven.Click += new System.EventHandler(this.buttonInputSeven_Click);
            // 
            // buttonInputSix
            // 
            this.buttonInputSix.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputSix.Location = new System.Drawing.Point(229, 233);
            this.buttonInputSix.Name = "buttonInputSix";
            this.buttonInputSix.Size = new System.Drawing.Size(107, 78);
            this.buttonInputSix.TabIndex = 8;
            this.buttonInputSix.Text = "6";
            this.buttonInputSix.UseVisualStyleBackColor = true;
            this.buttonInputSix.表示文字列 = "6";
            this.buttonInputSix.Click += new System.EventHandler(this.buttonInputSix_Click);
            // 
            // buttonInputFive
            // 
            this.buttonInputFive.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputFive.Location = new System.Drawing.Point(116, 233);
            this.buttonInputFive.Name = "buttonInputFive";
            this.buttonInputFive.Size = new System.Drawing.Size(107, 78);
            this.buttonInputFive.TabIndex = 7;
            this.buttonInputFive.Text = "5";
            this.buttonInputFive.UseVisualStyleBackColor = true;
            this.buttonInputFive.表示文字列 = "5";
            this.buttonInputFive.Click += new System.EventHandler(this.buttonInputFive_Click);
            // 
            // buttonInputFour
            // 
            this.buttonInputFour.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputFour.Location = new System.Drawing.Point(3, 233);
            this.buttonInputFour.Name = "buttonInputFour";
            this.buttonInputFour.Size = new System.Drawing.Size(107, 78);
            this.buttonInputFour.TabIndex = 6;
            this.buttonInputFour.Text = "4";
            this.buttonInputFour.UseVisualStyleBackColor = true;
            this.buttonInputFour.表示文字列 = "4";
            this.buttonInputFour.Click += new System.EventHandler(this.buttonInputFour_Click);
            // 
            // buttonInputThree
            // 
            this.buttonInputThree.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputThree.Location = new System.Drawing.Point(229, 317);
            this.buttonInputThree.Name = "buttonInputThree";
            this.buttonInputThree.Size = new System.Drawing.Size(107, 78);
            this.buttonInputThree.TabIndex = 5;
            this.buttonInputThree.Text = "3";
            this.buttonInputThree.UseVisualStyleBackColor = true;
            this.buttonInputThree.表示文字列 = "3";
            this.buttonInputThree.Click += new System.EventHandler(this.buttonInputThree_Click);
            // 
            // buttonInputTwo
            // 
            this.buttonInputTwo.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputTwo.Location = new System.Drawing.Point(116, 317);
            this.buttonInputTwo.Name = "buttonInputTwo";
            this.buttonInputTwo.Size = new System.Drawing.Size(107, 78);
            this.buttonInputTwo.TabIndex = 4;
            this.buttonInputTwo.Text = "2";
            this.buttonInputTwo.UseVisualStyleBackColor = true;
            this.buttonInputTwo.表示文字列 = "2";
            this.buttonInputTwo.Click += new System.EventHandler(this.buttonInputTwo_Click);
            // 
            // buttonInputZero
            // 
            this.buttonInputZero.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputZero.Location = new System.Drawing.Point(116, 401);
            this.buttonInputZero.Name = "buttonInputZero";
            this.buttonInputZero.Size = new System.Drawing.Size(107, 78);
            this.buttonInputZero.TabIndex = 3;
            this.buttonInputZero.Text = "0";
            this.buttonInputZero.UseVisualStyleBackColor = true;
            this.buttonInputZero.表示文字列 = "0";
            this.buttonInputZero.Click += new System.EventHandler(this.buttonInputZero_Click);
            // 
            // buttonInputOne
            // 
            this.buttonInputOne.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputOne.Location = new System.Drawing.Point(3, 317);
            this.buttonInputOne.Name = "buttonInputOne";
            this.buttonInputOne.Size = new System.Drawing.Size(107, 78);
            this.buttonInputOne.TabIndex = 1;
            this.buttonInputOne.Text = "1";
            this.buttonInputOne.UseVisualStyleBackColor = true;
            this.buttonInputOne.表示文字列 = "1";
            this.buttonInputOne.Click += new System.EventHandler(this.buttonInputOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 486);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCommandClear);
            this.Controls.Add(this.buttonInputDot);
            this.Controls.Add(this.buttonCommandDivide);
            this.Controls.Add(this.buttonCommandMultiple);
            this.Controls.Add(this.buttonCommandMinus);
            this.Controls.Add(this.buttonCommandPlus);
            this.Controls.Add(this.buttonCommandEqual);
            this.Controls.Add(this.buttonInputNine);
            this.Controls.Add(this.buttonInputEight);
            this.Controls.Add(this.buttonInputSeven);
            this.Controls.Add(this.buttonInputSix);
            this.Controls.Add(this.buttonInputFive);
            this.Controls.Add(this.buttonInputFour);
            this.Controls.Add(this.buttonInputThree);
            this.Controls.Add(this.buttonInputTwo);
            this.Controls.Add(this.buttonInputZero);
            this.Controls.Add(this.buttonInputOne);
            this.Name = "Form1";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.ButtonEx buttonInputOne;
        private Controls.ButtonEx buttonInputZero;
        private Controls.ButtonEx buttonInputTwo;
        private Controls.ButtonEx buttonInputThree;
        private Controls.ButtonEx buttonInputSix;
        private Controls.ButtonEx buttonInputFive;
        private Controls.ButtonEx buttonInputFour;
        private Controls.ButtonEx buttonInputNine;
        private Controls.ButtonEx buttonInputEight;
        private Controls.ButtonEx buttonInputSeven;
        private Controls.ButtonEx buttonCommandEqual;
        private Controls.ButtonEx buttonCommandMultiple;
        private Controls.ButtonEx buttonCommandMinus;
        private Controls.ButtonEx buttonCommandPlus;
        private Controls.ButtonEx buttonCommandDivide;
        private Controls.ButtonEx buttonInputDot;
        private Controls.ButtonEx buttonCommandClear;
        private System.Windows.Forms.TextBox textBox2;
    }
}

