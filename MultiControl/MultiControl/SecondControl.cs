using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSActiveX
{
    public partial class SecondControl : UserControl
    {
        public new event EventHandler ButtonGoMainClicked;
        public SecondControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonGoMainClicked(sender, e);
        }
    }
}
