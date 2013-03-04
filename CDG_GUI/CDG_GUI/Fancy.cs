using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDG_GUI
{
    public partial class Fancy : Form
    {
        int newPosX = 0;
        int newPosY = 0;

        static SqlCeConnection conn = new SqlCeConnection("Data Source = gameData.sdf;");
        DataTable dt = new DataTable();
        SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM games", conn);
        
        public Fancy()
        {
            InitializeComponent();
        }

        private void Fancy_Load(object sender, EventArgs e)
        {
            tabControl1.Location = new Point(100, 0);
            tabControl1.Size = new Size(Fancy.ActiveForm.Width - 216, Fancy.ActiveForm.Height - 140);

            try
            {
                conn.Open();
                da.Fill(dt);
            }
            catch
            {
               MessageBox.Show("Connection Failure!!!");
            }

            newPosX = (tabControl1.Width / 2 - 250);
            newPosY = 25;
            PictureBox[] game = new PictureBox[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                game[i] = new PictureBox();
                game[i].Name = Convert.ToString(i+1);
                game[i].Size = new Size(100, 100);
                game[i].Location = new Point(newPosX, newPosY);
                game[i].ImageLocation = "images\\door.png";
                game[i].Click += new EventHandler(gameSelect);
                tabPage1.Controls.Add(game[i]);
                newPosX += 100;
                if ((i % 5) == 0)
                {
                    newPosY += 120;
                    newPosX -= 500;
                }
            }
        }
        private void gameSelect(object sender, EventArgs e)
        {
            PictureBox target = sender as PictureBox;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (target.Name == Convert.ToString(dt.Rows[i][0]))
                {
                    Form1 frm1 = new Form1();
                    frm1.gameName = Convert.ToString(dt.Rows[i][1]);
                    frm1.gameAuthor = Convert.ToString(dt.Rows[i][2]);
                    frm1.gameDesc = Convert.ToString(dt.Rows[i][3]);
                    frm1.gameImg1 = Convert.ToString(dt.Rows[i][4]);
                    frm1.gameImg2 = Convert.ToString(dt.Rows[i][5]);
                    frm1.gameType = Convert.ToString(dt.Rows[i][6]);
                    frm1.gameLocation = Convert.ToString(dt.Rows[i][7]);
                    frm1.Show();
                }
            }       
        }
 
    }
}
