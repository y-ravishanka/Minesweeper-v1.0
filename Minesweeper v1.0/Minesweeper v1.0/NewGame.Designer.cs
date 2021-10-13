
namespace Minesweeper_v1._0
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.butGame = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mup = new System.Windows.Forms.PictureBox();
            this.sup = new System.Windows.Forms.PictureBox();
            this.mdown = new System.Windows.Forms.PictureBox();
            this.sdown = new System.Windows.Forms.PictureBox();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picMini);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 35);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 108);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLbl
            // 
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.Location = new System.Drawing.Point(12, 106);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(138, 108);
            this.minLbl.TabIndex = 12;
            this.minLbl.Text = "35";
            this.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secLbl
            // 
            this.secLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(217, 106);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(138, 108);
            this.secLbl.TabIndex = 12;
            this.secLbl.Text = "35";
            this.secLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butGame
            // 
            this.butGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGame.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame.Location = new System.Drawing.Point(12, 291);
            this.butGame.Name = "butGame";
            this.butGame.Size = new System.Drawing.Size(331, 42);
            this.butGame.TabIndex = 13;
            this.butGame.Text = "New Game";
            this.butGame.UseVisualStyleBackColor = true;
            this.butGame.Click += new System.EventHandler(this.butGame_Click);
            // 
            // butMenu
            // 
            this.butMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMenu.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.Location = new System.Drawing.Point(12, 353);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(331, 42);
            this.butMenu.TabIndex = 13;
            this.butMenu.Text = "Main Menu";
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "MINESWEEPER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // mup
            // 
            this.mup.Image = global::Minesweeper_v1._0.Properties.Resources.up;
            this.mup.Location = new System.Drawing.Point(12, 56);
            this.mup.Name = "mup";
            this.mup.Size = new System.Drawing.Size(123, 44);
            this.mup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mup.TabIndex = 11;
            this.mup.TabStop = false;
            this.mup.Click += new System.EventHandler(this.mup_Click);
            // 
            // sup
            // 
            this.sup.Image = global::Minesweeper_v1._0.Properties.Resources.up;
            this.sup.Location = new System.Drawing.Point(220, 56);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(123, 44);
            this.sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sup.TabIndex = 10;
            this.sup.TabStop = false;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // mdown
            // 
            this.mdown.Image = global::Minesweeper_v1._0.Properties.Resources.down;
            this.mdown.Location = new System.Drawing.Point(12, 220);
            this.mdown.Name = "mdown";
            this.mdown.Size = new System.Drawing.Size(123, 44);
            this.mdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mdown.TabIndex = 9;
            this.mdown.TabStop = false;
            this.mdown.Click += new System.EventHandler(this.mdown_Click);
            // 
            // sdown
            // 
            this.sdown.Image = global::Minesweeper_v1._0.Properties.Resources.down;
            this.sdown.Location = new System.Drawing.Point(220, 220);
            this.sdown.Name = "sdown";
            this.sdown.Size = new System.Drawing.Size(123, 44);
            this.sdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sdown.TabIndex = 8;
            this.sdown.TabStop = false;
            this.sdown.Click += new System.EventHandler(this.sdown_Click);
            // 
            // picMini
            // 
            this.picMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMini.Image = global::Minesweeper_v1._0.Properties.Resources.minimize;
            this.picMini.Location = new System.Drawing.Point(285, 0);
            this.picMini.Name = "picMini";
            this.picMini.Size = new System.Drawing.Size(35, 35);
            this.picMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMini.TabIndex = 12;
            this.picMini.TabStop = false;
            this.picMini.Click += new System.EventHandler(this.picMini_Click);
            // 
            // picExit
            // 
            this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExit.Image = global::Minesweeper_v1._0.Properties.Resources.close;
            this.picExit.Location = new System.Drawing.Point(320, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(35, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 11;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 420);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.butGame);
            this.Controls.Add(this.secLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.mup);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.mdown);
            this.Controls.Add(this.sdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(355, 420);
            this.MinimumSize = new System.Drawing.Size(355, 420);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox sdown;
        private System.Windows.Forms.PictureBox mdown;
        private System.Windows.Forms.PictureBox mup;
        private System.Windows.Forms.PictureBox sup;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Button butGame;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label2;
    }
}