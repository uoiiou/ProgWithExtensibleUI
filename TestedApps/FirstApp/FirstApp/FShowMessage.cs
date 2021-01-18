using System;
using System.Windows.Forms;
using AttributePanelLoad;
using AttributeGroupBox;
using AttributeTabControl;

namespace FirstApp
{
    [OnPanel(true)]
    [OnGroupBox(true)]
    [OnTabControl(true)]
    public partial class FShowMessage : Form
    {
        public FShowMessage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbMessage.Text, "Info from textbox", MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}