using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CallAddButton_Click(object sender, EventArgs e)
        {
            var svc = new CalcSvc.CalculatorServiceClient();
            var result = svc.Add(2, 5);
            MessageBox.Show(result.ToString());
        }
    }
}
