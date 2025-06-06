using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGA
{
    public partial class WarningsForm : Form
    {
        public WarningsForm()
        {
            InitializeComponent();
        }

        public DialogResult Show(string message, int timeWait=3000)
        {
            Messages.Text="";
            Messages.Text = message;
            this.TopLevel = true;
            this.Visible = true;
            pictureBox1.Focus();
            this.Update();
            this.Refresh();
            Thread.Sleep(timeWait);
            this.Close();
            return DialogResult.OK;
        }
    }
}
