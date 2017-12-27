using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ZacksBrowser
{
    public partial class Browser : Form
    {
        public Browser() //Startup code
        {
            InitializeComponent();
            string HomeDir = (Directory.GetCurrentDirectory() + "\\" + "Homepage.txt");
            string AboutDir = File.ReadAllText(HomeDir);
            webBrowser1.Navigate(AboutDir);
            LightTheme();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) //When the browser finishes loading a page do this
        {
            textBox1.Text = webBrowser1.Url.ToString();
            Text = textBox1.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) //When the user changes the URL text do this
        {
            
        }

        private void Button1_Click(object sender, EventArgs e) //Go button
        {
            if (textBox1.Text == null)
            {
                string WkDir = Directory.GetCurrentDirectory();
                string HpDir = (WkDir + "\\" + "Homepage.txt");
                webBrowser1.Navigate(HpDir);
            }
            else
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void Button3_Click(object sender, EventArgs e) //Back button
        {
            webBrowser1.GoBack();
        }

        private void Button4_Click(object sender, EventArgs e) //Forward button
        {
            webBrowser1.GoForward();
        }

        private void Button5_Click(object sender, EventArgs e) //Home button
        {
            string HomeDir = (Directory.GetCurrentDirectory() + "\\" + "Homepage.txt");
            string AboutDir = File.ReadAllText(HomeDir);
            webBrowser1.Navigate(AboutDir);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File-About menu item
            string AboutDir = Directory.GetCurrentDirectory() + "\\" + "About.html";
            webBrowser1.Navigate(AboutDir);
        }

        private void SetPageAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File-Set Page as Home menu item
            string HomeDir = (Directory.GetCurrentDirectory() + "\\" + "Homepage.txt");
            System.IO.File.WriteAllText(HomeDir, textBox1.Text);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File-Exit menu item
            this.Text = ("Goodbye!");
            Thread.Sleep(900);
            Application.Exit();
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Window-Themes-Dark menu item
            DarkTheme();
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Window-Themes-Light menu item
            LightTheme();
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Window-New Window menu item
            string wd = Directory.GetCurrentDirectory();
            string exe = (wd + "\\" + "ZacksBrowser.exe");
            Process.Start(exe);
        }

        private void ViewOnGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Browser-View on GitHub menu item
            webBrowser1.Navigate("http://www.github.com/zaxophone/ZacksBrowser");
        }

        public void LightTheme()
        {
            //Light theme
            BackColor = Color.FromArgb(250, 235, 235);
            button5.BackColor = Color.FromArgb(245, 245, 245);
            button5.ForeColor = Color.FromArgb(0, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.FromArgb(254, 245, 245);
            button5.FlatAppearance.BorderSize = 1;
            button4.BackColor = Color.FromArgb(245, 245, 245);
            button4.ForeColor = Color.FromArgb(0, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.FromArgb(254, 245, 245);
            button4.FlatAppearance.BorderSize = 1;
            button3.BackColor = Color.FromArgb(245, 245, 245);
            button3.ForeColor = Color.FromArgb(0, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.FromArgb(254, 245, 245);
            button3.FlatAppearance.BorderSize = 1;
            button1.BackColor = Color.FromArgb(245, 245, 245);
            button1.ForeColor = Color.FromArgb(0, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(254, 245, 245);
            button1.FlatAppearance.BorderSize = 1;
            textBox1.BackColor = Color.FromArgb(254, 245, 245);
            textBox1.ForeColor = Color.FromArgb(0, 0, 0);
            menuStrip1.BackColor = Color.FromArgb(199, 199, 199);
            menuStrip1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        public void DarkTheme()
        {
            //Dark Theme
            BackColor = Color.FromArgb(25, 23, 23);
            button5.BackColor = Color.FromArgb(45, 41, 41);
            button5.ForeColor = Color.FromArgb(155, 149, 149);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.FromArgb(35, 33, 33);
            button5.FlatAppearance.BorderSize = 1;
            button4.BackColor = Color.FromArgb(45, 41, 41);
            button4.ForeColor = Color.FromArgb(155, 149, 149);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.FromArgb(35, 33, 33);
            button4.FlatAppearance.BorderSize = 1;
            button3.BackColor = Color.FromArgb(45, 41, 41);
            button3.ForeColor = Color.FromArgb(155, 149, 149);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.FromArgb(35, 33, 33);
            button3.FlatAppearance.BorderSize = 1;
            button1.BackColor = Color.FromArgb(45, 41, 41);
            button1.ForeColor = Color.FromArgb(155, 149, 149);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(35, 33, 33);
            button1.FlatAppearance.BorderSize = 1;
            textBox1.BackColor = Color.FromArgb(35, 33, 33);
            textBox1.ForeColor = Color.FromArgb(155, 149, 149);
            menuStrip1.BackColor = Color.FromArgb(10, 10, 10);
            menuStrip1.ForeColor = Color.FromArgb(155, 149, 149);
        }
    }
}
