using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs105E
{
    public partial class Form1 : Form
    {
        private ListBox lbx;
        private Button bt;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Open another app";
            this.Width = 250;
            this.Height = 200;
            string dir = "C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs105E\\WindowsFormsAppEasyCs105E\\test\\";

            string[] name = Directory.GetFiles(dir);
            lbx = new ListBox();
            lbx.Dock = DockStyle.Top;

            for (int i = 0; i < name.Length; i++)
            {
                lbx.Items.Add(name[i]);
            }

            bt = new Button();
            bt.Text = "Open with";
            bt.Dock = DockStyle.Bottom;

            lbx.Parent = this;
            bt.Parent = this;
            bt.Click += new EventHandler(BtClick);
        }

        public void BtClick(Object sender, EventArgs e)
        {
            string name = lbx.SelectedItem.ToString();
            if (name != null)
            {
                // Open the file with the default app
                Process.Start(@name);
            }
        }
    }
}