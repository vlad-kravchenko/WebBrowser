using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolBack_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolForward_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void tooUpdate_Click(object sender, System.EventArgs e)
        {
            webBrowser1.Update();
        }

        private void tooGo_Click(object sender, System.EventArgs e)
        {
            if (!tbRequest.Text.Contains("http")) webBrowser1.Navigate("http://" + tbRequest.Text);
            else webBrowser1.Navigate(tbRequest.Text);
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            tbRequest.Size = new Size(Width - 150, tbRequest.Height);
        }

        private void tbRequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!tbRequest.Text.Contains("http")) webBrowser1.Navigate("http://" + tbRequest.Text);
                else webBrowser1.Navigate(tbRequest.Text);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
