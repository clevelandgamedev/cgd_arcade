namespace CDG_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_games = new System.Windows.Forms.ListBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.pb_img1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.gameDataDataSet = new CDG_GUI.gameDataDataSet();
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataTableAdapter = new CDG_GUI.gameDataDataSetTableAdapters.gameDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_games
            // 
            this.lb_games.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gameDataBindingSource, "Title", true));
            this.lb_games.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_games.FormattingEnabled = true;
            this.lb_games.Location = new System.Drawing.Point(0, 0);
            this.lb_games.Name = "lb_games";
            this.lb_games.Size = new System.Drawing.Size(240, 561);
            this.lb_games.TabIndex = 0;
            this.lb_games.SelectedIndexChanged += new System.EventHandler(this.lb_games_SelectedIndexChanged);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(1001, 201);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(131, 51);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_desc.Location = new System.Drawing.Point(246, 264);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(886, 285);
            this.tb_desc.TabIndex = 2;
            // 
            // pb_img1
            // 
            this.pb_img1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_img1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_img1.Location = new System.Drawing.Point(246, 12);
            this.pb_img1.Name = "pb_img1";
            this.pb_img1.Size = new System.Drawing.Size(440, 240);
            this.pb_img1.TabIndex = 3;
            this.pb_img1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author(s):";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(715, 36);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(58, 24);
            this.lbl_author.TabIndex = 5;
            this.lbl_author.Text = "name";
            // 
            // gameDataDataSet
            // 
            this.gameDataDataSet.DataSetName = "gameDataDataSet";
            this.gameDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataMember = "gameData";
            this.gameDataBindingSource.DataSource = this.gameDataDataSet;
            // 
            // gameDataTableAdapter
            // 
            this.gameDataTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 561);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_img1);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lb_games);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleveland Game Developers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_games;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.PictureBox pb_img1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_author;
        private gameDataDataSet gameDataDataSet;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private gameDataDataSetTableAdapters.gameDataTableAdapter gameDataTableAdapter;
    }
}

