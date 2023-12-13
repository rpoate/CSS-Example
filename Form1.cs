using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.CSSText = "BODY {background-color: lightblue; font-family: tahoma} TABLE, TD {border-color: #99aa11 !important; }";

            this.htmlEditControl1.InlineCSS.Add("border: 1px solid green; font-size: 2em;");
            this.htmlEditControl1.InlineCSS.Add("border: 1px solid orange");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
