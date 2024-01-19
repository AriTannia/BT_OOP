namespace BT4_Chuong3
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
            this.gbHobby = new System.Windows.Forms.GroupBox();
            this.gbFColo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbWFilm = new System.Windows.Forms.CheckBox();
            this.cbSport = new System.Windows.Forms.CheckBox();
            this.cbShopping = new System.Windows.Forms.CheckBox();
            this.cbTravel = new System.Windows.Forms.CheckBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbPink = new System.Windows.Forms.RadioButton();
            this.rbPurple = new System.Windows.Forms.RadioButton();
            this.btnHobby = new System.Windows.Forms.Button();
            this.btnFColo = new System.Windows.Forms.Button();
            this.gbHobby.SuspendLayout();
            this.gbFColo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHobby
            // 
            this.gbHobby.Controls.Add(this.cbTravel);
            this.gbHobby.Controls.Add(this.cbShopping);
            this.gbHobby.Controls.Add(this.cbSport);
            this.gbHobby.Controls.Add(this.cbWFilm);
            this.gbHobby.Controls.Add(this.cbMusic);
            this.gbHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHobby.Location = new System.Drawing.Point(53, 67);
            this.gbHobby.Name = "gbHobby";
            this.gbHobby.Size = new System.Drawing.Size(234, 225);
            this.gbHobby.TabIndex = 0;
            this.gbHobby.TabStop = false;
            this.gbHobby.Text = "Sở thích của bạn";
            // 
            // gbFColo
            // 
            this.gbFColo.Controls.Add(this.rbPurple);
            this.gbFColo.Controls.Add(this.rbPink);
            this.gbFColo.Controls.Add(this.rbYellow);
            this.gbFColo.Controls.Add(this.rbWhite);
            this.gbFColo.Controls.Add(this.rbRed);
            this.gbFColo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFColo.Location = new System.Drawing.Point(330, 67);
            this.gbFColo.Name = "gbFColo";
            this.gbFColo.Size = new System.Drawing.Size(222, 225);
            this.gbFColo.TabIndex = 1;
            this.gbFColo.TabStop = false;
            this.gbFColo.Text = "Màu bạn thích";
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(18, 41);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(111, 24);
            this.cbMusic.TabIndex = 0;
            this.cbMusic.Text = "Nghe nhạc";
            this.cbMusic.UseVisualStyleBackColor = true;
            // 
            // cbWFilm
            // 
            this.cbWFilm.AutoSize = true;
            this.cbWFilm.Location = new System.Drawing.Point(18, 73);
            this.cbWFilm.Name = "cbWFilm";
            this.cbWFilm.Size = new System.Drawing.Size(106, 24);
            this.cbWFilm.TabIndex = 1;
            this.cbWFilm.Text = "Xem phim";
            this.cbWFilm.UseVisualStyleBackColor = true;
            // 
            // cbSport
            // 
            this.cbSport.AutoSize = true;
            this.cbSport.Location = new System.Drawing.Point(18, 105);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(130, 24);
            this.cbSport.TabIndex = 2;
            this.cbSport.Text = "Chơi thể thao";
            this.cbSport.UseVisualStyleBackColor = true;
            // 
            // cbShopping
            // 
            this.cbShopping.AutoSize = true;
            this.cbShopping.Location = new System.Drawing.Point(18, 137);
            this.cbShopping.Name = "cbShopping";
            this.cbShopping.Size = new System.Drawing.Size(121, 24);
            this.cbShopping.TabIndex = 3;
            this.cbShopping.Text = "Đi mua sắm";
            this.cbShopping.UseVisualStyleBackColor = true;
            // 
            // cbTravel
            // 
            this.cbTravel.AutoSize = true;
            this.cbTravel.Location = new System.Drawing.Point(18, 169);
            this.cbTravel.Name = "cbTravel";
            this.cbTravel.Size = new System.Drawing.Size(101, 24);
            this.cbTravel.TabIndex = 4;
            this.cbTravel.Text = "Đi du lịch";
            this.cbTravel.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(17, 31);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(51, 24);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Đỏ";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(17, 65);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(73, 24);
            this.rbWhite.TabIndex = 1;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "Trắng";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(17, 99);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(68, 24);
            this.rbYellow.TabIndex = 2;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Vàng";
            this.rbYellow.UseVisualStyleBackColor = true;
            // 
            // rbPink
            // 
            this.rbPink.AutoSize = true;
            this.rbPink.Location = new System.Drawing.Point(17, 133);
            this.rbPink.Name = "rbPink";
            this.rbPink.Size = new System.Drawing.Size(70, 24);
            this.rbPink.TabIndex = 3;
            this.rbPink.TabStop = true;
            this.rbPink.Text = "Hồng";
            this.rbPink.UseVisualStyleBackColor = true;
            // 
            // rbPurple
            // 
            this.rbPurple.AutoSize = true;
            this.rbPurple.Location = new System.Drawing.Point(17, 167);
            this.rbPurple.Name = "rbPurple";
            this.rbPurple.Size = new System.Drawing.Size(58, 24);
            this.rbPurple.TabIndex = 4;
            this.rbPurple.TabStop = true;
            this.rbPurple.Text = "Tím";
            this.rbPurple.UseVisualStyleBackColor = true;
            // 
            // btnHobby
            // 
            this.btnHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHobby.Location = new System.Drawing.Point(71, 320);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(172, 37);
            this.btnHobby.TabIndex = 2;
            this.btnHobby.Text = "Sở thích của bạn";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // btnFColo
            // 
            this.btnFColo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFColo.Location = new System.Drawing.Point(363, 320);
            this.btnFColo.Name = "btnFColo";
            this.btnFColo.Size = new System.Drawing.Size(148, 37);
            this.btnFColo.TabIndex = 3;
            this.btnFColo.Text = "Màu bạn thích";
            this.btnFColo.UseVisualStyleBackColor = true;
            this.btnFColo.Click += new System.EventHandler(this.btnFColo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.btnFColo);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.gbFColo);
            this.Controls.Add(this.gbHobby);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbHobby.ResumeLayout(false);
            this.gbHobby.PerformLayout();
            this.gbFColo.ResumeLayout(false);
            this.gbFColo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHobby;
        private System.Windows.Forms.GroupBox gbFColo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbTravel;
        private System.Windows.Forms.CheckBox cbShopping;
        private System.Windows.Forms.CheckBox cbSport;
        private System.Windows.Forms.CheckBox cbWFilm;
        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.RadioButton rbPurple;
        private System.Windows.Forms.RadioButton rbPink;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.Button btnHobby;
        private System.Windows.Forms.Button btnFColo;
    }
}

