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
        public SqlCeConnection conn = new SqlCeConnection("Data Source = gameData.sdf;");
        public DataTable dt = new DataTable();
        public string gamePlay = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                tb_desc.Text = "Sorry there was a problem with the database connection";
            }

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM games", conn);
            
            da.Fill(dt);
            for (int i = 0; i <= dt.Rows.Count-1; i++)
            {
                lb_games.Items.Add(dt.Rows[i][1]);
            }
            lb_games.SelectedIndex = 0;

        }

        private void lb_games_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_author.Text = Convert.ToString(dt.Rows[lb_games.SelectedIndex][2]);
            tb_desc.Text = Convert.ToString(dt.Rows[lb_games.SelectedIndex][3]);
            pb_img1.ImageLocation = (Convert.ToString(dt.Rows[lb_games.SelectedIndex][4]));
            gamePlay = Convert.ToString(dt.Rows[lb_games.SelectedIndex][6]);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Process.Start(gamePlay);
        }
    }
}
