using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Controls
{
    public partial class ButtonEx : System.Windows.Forms.Button
    {
        private String label = "";

        [Browsable(true)]
        [Description("表示文字列を指定します。")]
        [Category("表示")]
        public String 表示文字列
        {
            get { return label; }
            set
            {
                label = value;
                this.Text = label;
            }
        }

        public ButtonEx()
        {
            InitializeComponent();
        }

        //    public ButtonBase(IContainer container)
        //    {
        //        container.Add(this);

        //        InitializeComponent();
        //    }
    }
}
