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
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataDataSet = new CDG_GUI.gameDataDataSet();
            this.btn_play = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.pb_img1 = new System.Windows.Forms.PictureBox();
            this.gameDataTableAdapter = new CDG_GUI.gameDataDataSetTableAdapters.gameDataTableAdapter();
            this.pb_img2 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl_gameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataMember = "gameData";
            this.gameDataBindingSource.DataSource = this.gameDataDataSet;
            // 
            // gameDataDataSet
            // 
            this.gameDataDataSet.DataSetName = "gameDataDataSet";
            this.gameDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(1001, 201);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(131, 51);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // tb_desc
            // 
            this.tb_desc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_desc.Location = new System.Drawing.Point(12, 299);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(760, 209);
            this.tb_desc.TabIndex = 2;
            // 
            // pb_img1
            // 
            this.pb_img1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_img1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_img1.Location = new System.Drawing.Point(12, 53);
            this.pb_img1.Name = "pb_img1";
            this.pb_img1.Size = new System.Drawing.Size(380, 240);
            this.pb_img1.TabIndex = 3;
            this.pb_img1.TabStop = false;
            // 
            // gameDataTableAdapter
            // 
            this.gameDataTableAdapter.ClearBeforeFill = true;
            // 
            // pb_img2
            // 
            this.pb_img2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_img2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_img2.Location = new System.Drawing.Point(398, 53);
            this.pb_img2.Name = "pb_img2";
            this.pb_img2.Size = new System.Drawing.Size(380, 240);
            this.pb_img2.TabIndex = 6;
            this.pb_img2.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(540, 515);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(113, 34);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl_gameName
            // 
            this.lbl_gameName.AutoSize = true;
            this.lbl_gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameName.Location = new System.Drawing.Point(12, 9);
            this.lbl_gameName.Name = "lbl_gameName";
            this.lbl_gameName.Size = new System.Drawing.Size(86, 31);
            this.lbl_gameName.TabIndex = 9;
            this.lbl_gameName.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_gameName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pb_img2);
            this.Controls.Add(this.pb_img1);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleveland Game Developers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.PictureBox pb_img1;
        private gameDataDataSet gameDataDataSet;
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private gameDataDataSetTableAdapters.gameDataTableAdapter gameDataTableAdapter;
        private System.Windows.Forms.PictureBox pb_img2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl_gameName;
    }
}

