namespace WordGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eng_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tr_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.correct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.btn_game = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "English:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.eng_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 40);
            this.panel1.TabIndex = 1;
            // 
            // eng_txt
            // 
            this.eng_txt.BackColor = System.Drawing.Color.DodgerBlue;
            this.eng_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eng_txt.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F);
            this.eng_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.eng_txt.Location = new System.Drawing.Point(121, 3);
            this.eng_txt.Name = "eng_txt";
            this.eng_txt.ReadOnly = true;
            this.eng_txt.Size = new System.Drawing.Size(231, 31);
            this.eng_txt.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.tr_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 40);
            this.panel2.TabIndex = 2;
            // 
            // tr_txt
            // 
            this.tr_txt.BackColor = System.Drawing.Color.DodgerBlue;
            this.tr_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tr_txt.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F);
            this.tr_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.tr_txt.Location = new System.Drawing.Point(121, 4);
            this.tr_txt.Name = "tr_txt";
            this.tr_txt.Size = new System.Drawing.Size(231, 31);
            this.tr_txt.TabIndex = 2;
            this.tr_txt.TextChanged += new System.EventHandler(this.tr_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turkish:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.correct);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.time);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.time_lbl);
            this.panel3.Location = new System.Drawing.Point(351, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 86);
            this.panel3.TabIndex = 3;
            // 
            // correct
            // 
            this.correct.AutoSize = true;
            this.correct.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F);
            this.correct.Location = new System.Drawing.Point(302, 25);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(26, 30);
            this.correct.TabIndex = 10;
            this.correct.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(209, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correct:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WordGame.Properties.Resources.check_5610944;
            this.pictureBox2.Location = new System.Drawing.Point(176, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F);
            this.time.Location = new System.Drawing.Point(117, 25);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 30);
            this.time.TabIndex = 5;
            this.time.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordGame.Properties.Resources.clock_10518167;
            this.pictureBox1.Location = new System.Drawing.Point(24, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.time_lbl.Location = new System.Drawing.Point(51, 25);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(70, 30);
            this.time_lbl.TabIndex = 2;
            this.time_lbl.Text = "Time:";
            // 
            // btn_game
            // 
            this.btn_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_game.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_game.Location = new System.Drawing.Point(526, 196);
            this.btn_game.Name = "btn_game";
            this.btn_game.Size = new System.Drawing.Size(177, 36);
            this.btn_game.TabIndex = 4;
            this.btn_game.Text = "Start";
            this.btn_game.UseVisualStyleBackColor = true;
            this.btn_game.Click += new System.EventHandler(this.btn_game_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(703, 244);
            this.Controls.Add(this.btn_game);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox eng_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tr_txt;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label correct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_game;
        private System.Windows.Forms.Timer timer1;
    }
}

