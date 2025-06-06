using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOGA
{
    partial class OpeningSplash : Form
    {
        public OpeningSplash()
        {
            InitializeComponent();
            this.LoadingLabel.Visible = false;
            this.Opacity = 0;
            fadeIn();
        }

        private void fadeIn()
        {
            while (true)
            {
                if (this.Opacity >= 1)
                {
                    break;
                }
                this.Opacity += 0.05;
                this.Refresh();
                this.Update();
                this.Show();
                Thread.Sleep(10);
            }
        }

    }
}
