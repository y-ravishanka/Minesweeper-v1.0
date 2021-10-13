
namespace Minesweeper_v1._0
{
    partial class Score
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHScore = new System.Windows.Forms.Panel();
            this.butHScore = new System.Windows.Forms.Button();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.butScore = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.butMenu = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlHScore.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(555, 35);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "MINESWEEPER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picMini
            // 
            this.picMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.picMini.Image = global::Minesweeper_v1._0.Properties.Resources.minimize;
            this.picMini.Location = new System.Drawing.Point(485, 0);
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
            this.picExit.Location = new System.Drawing.Point(520, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(35, 35);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 11;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlHScore);
            this.panel2.Controls.Add(this.pnlScore);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 43);
            this.panel2.TabIndex = 6;
            // 
            // pnlHScore
            // 
            this.pnlHScore.BackColor = System.Drawing.Color.LightGray;
            this.pnlHScore.Controls.Add(this.butHScore);
            this.pnlHScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHScore.Location = new System.Drawing.Point(279, 0);
            this.pnlHScore.Name = "pnlHScore";
            this.pnlHScore.Size = new System.Drawing.Size(249, 43);
            this.pnlHScore.TabIndex = 10;
            // 
            // butHScore
            // 
            this.butHScore.BackColor = System.Drawing.Color.White;
            this.butHScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.butHScore.FlatAppearance.BorderSize = 0;
            this.butHScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHScore.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHScore.Location = new System.Drawing.Point(0, 0);
            this.butHScore.Name = "butHScore";
            this.butHScore.Size = new System.Drawing.Size(249, 34);
            this.butHScore.TabIndex = 1;
            this.butHScore.Text = "Hight Score";
            this.butHScore.UseVisualStyleBackColor = false;
            this.butHScore.Click += new System.EventHandler(this.butHScore_Click);
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.LightGray;
            this.pnlScore.Controls.Add(this.butScore);
            this.pnlScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlScore.Location = new System.Drawing.Point(27, 0);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(249, 43);
            this.pnlScore.TabIndex = 9;
            // 
            // butScore
            // 
            this.butScore.BackColor = System.Drawing.Color.White;
            this.butScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.butScore.FlatAppearance.BorderSize = 0;
            this.butScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butScore.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butScore.Location = new System.Drawing.Point(0, 0);
            this.butScore.Name = "butScore";
            this.butScore.Size = new System.Drawing.Size(249, 34);
            this.butScore.TabIndex = 0;
            this.butScore.Text = "Score";
            this.butScore.UseVisualStyleBackColor = false;
            this.butScore.Click += new System.EventHandler(this.butScore_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(528, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 43);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 43);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "MINESWEEPER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.data);
            this.panel7.Location = new System.Drawing.Point(27, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(501, 316);
            this.panel7.TabIndex = 8;
            // 
            // butMenu
            // 
            this.butMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMenu.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenu.Location = new System.Drawing.Point(389, 473);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(139, 39);
            this.butMenu.TabIndex = 9;
            this.butMenu.Text = "Main Menu";
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // butClear
            // 
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(244, 473);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(139, 39);
            this.butClear.TabIndex = 9;
            this.butClear.Text = "Clear Score";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.MaximumSize = new System.Drawing.Size(501, 316);
            this.data.MinimumSize = new System.Drawing.Size(501, 316);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersVisible = false;
            this.data.Size = new System.Drawing.Size(501, 316);
            this.data.TabIndex = 0;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 524);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butMenu);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 524);
            this.MinimumSize = new System.Drawing.Size(555, 524);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlHScore.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHScore;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button butScore;
        private System.Windows.Forms.Button butHScore;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.DataGridView data;
    }
}