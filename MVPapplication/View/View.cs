using System;
using System.Windows.Forms;

namespace MVPapplication
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler sendButtonPressing = null;        
        public event EventHandler xmlMenuItemPressing = null;
        public event EventHandler oleDbMenuItemPressing = null;
        public event EventHandler txtMenuItemPressing = null;
        public event EventHandler exitMenuItemPressing = null;

        private void OnSendButtonPressing(object sender, EventArgs e)
        {
            sendButtonPressing(sender, e);
        }
        
        private void OnXmlMenuItemPressing(object sender, EventArgs e)
        {
            xmlMenuItemPressing(sender, e);
        }

        private void OnOleDbMenuItemPressing(object sender, EventArgs e)
        {
            oleDbMenuItemPressing(sender, e);
        }
                
        private void OnTxtMenuItemPressing(object sender, EventArgs e)
        {
            txtMenuItemPressing(sender, e);
        }

        private void OnExitMenuItemPressing(object sender, EventArgs e)
        {
            exitMenuItemPressing(sender, e);
        }
    }
}
