using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Diagnostics;

namespace CDG_GUI
{
    public partial class Form1 : Form
    {
        public string gameName { get; set; }
        public string gameAuthor { get; set; }
        public string gameDesc { get; set; }
        public string gameImg1 { get; set; }
        public string gameImg2 { get; set; }
        public string gameType { get; set; }
        public string gameLocation { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CGD-Arcade ~*" + gameName + "*~";
            lbl_gameName.Text = gameName;
            pb_img1.ImageLocation = gameImg1;
            pb_img2.ImageLocation = gameImg2;
            tb_desc.Text += "Author: " + gameAuthor;
            tb_desc.Text += Environment.NewLine;
            tb_desc.Text += Environment.NewLine;
            tb_desc.Text += "Description: " + gameDesc;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Process.Start(gameLocation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
