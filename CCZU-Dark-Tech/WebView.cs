using System;
using System.Windows.Forms;

namespace CCZU_Dark_Tech
{
    public partial class WebView : Form
    {
        private bool configured = false;

        public WebView()
        {
            InitializeComponent();
        }

        public string Url
        {
            set
            {
                webBrowser1.Navigate(value);
                configured = true;
            }
        }

        public string Content
        {
            set
            {
                webBrowser1.DocumentText = value;
                configured = true;
            }
        }

        public new void ShowDialog()
        {
            if (!configured)
                return;
            base.ShowDialog();
        }

        public string Title
        {
            set
            {
                Text = value;
            }
            get
            {
                return Text;
            }
        }
    }
}
