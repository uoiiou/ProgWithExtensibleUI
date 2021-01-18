using System;
using System.Windows.Forms;
using AttributeGroupBox;
using AttributePanelLoad;
using AttributeTabControl;

namespace SecondApp
{
    [OnGroupBox(true)]
    [OnPanel(true)]
    [OnTabControl(false)]
    public partial class FColor : Form
    {
        public FColor()
        {
            InitializeComponent();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb1.Text;
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb2.Text;
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb3.Text;
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb4.Text;
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb5.Text;
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            textbox.Text = cb6.Text;
        }
    }
}