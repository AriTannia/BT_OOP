namespace BT7_Chuong3
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
            this.gbAclass = new System.Windows.Forms.GroupBox();
            this.LbAclass = new System.Windows.Forms.ListBox();
            this.gbBclass = new System.Windows.Forms.GroupBox();
            this.LbBclass = new System.Windows.Forms.ListBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDLeft = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbAclass.SuspendLayout();
            this.gbBclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(973, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAclass
            // 
            this.gbAclass.Controls.Add(this.LbAclass);
            this.gbAclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAclass.Location = new System.Drawing.Point(113, 174);
            this.gbAclass.Name = "gbAclass";
            this.gbAclass.Size = new System.Drawing.Size(225, 259);
            this.gbAclass.TabIndex = 2;
            this.gbAclass.TabStop = false;
            this.gbAclass.Text = "Lớp A";
            // 
            // LbAclass
            // 
            this.LbAclass.FormattingEnabled = true;
            this.LbAclass.ItemHeight = 18;
            this.LbAclass.Location = new System.Drawing.Point(19, 39);
            this.LbAclass.Name = "LbAclass";
            this.LbAclass.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbAclass.Size = new System.Drawing.Size(190, 202);
            this.LbAclass.TabIndex = 0;
            // 
            // gbBclass
            // 
            this.gbBclass.Controls.Add(this.LbBclass);
            this.gbBclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBclass.Location = new System.Drawing.Point(499, 174);
            this.gbBclass.Name = "gbBclass";
            this.gbBclass.Size = new System.Drawing.Size(225, 259);
            this.gbBclass.TabIndex = 3;
            this.gbBclass.TabStop = false;
            this.gbBclass.Text = "Lớp B";
            // 
            // LbBclass
            // 
            this.LbBclass.FormattingEnabled = true;
            this.LbBclass.ItemHeight = 18;
            this.LbBclass.Location = new System.Drawing.Point(26, 39);
            this.LbBclass.Name = "LbBclass";
            this.LbBclass.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbBclass.Size = new System.Drawing.Size(180, 202);
            this.LbBclass.TabIndex = 0;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(28, 124);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(91, 20);
            this.lblHoten.TabIndex = 3;
            this.lblHoten.Text = "Họ và tên: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(151, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(646, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(132, 450);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(180, 34);
            this.btnD.TabIndex = 7;
            this.btnD.Text = "&Xóa";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(525, 450);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(180, 34);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "&Kết Thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(383, 213);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 34);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDRight
            // 
            this.btnDRight.Location = new System.Drawing.Point(383, 259);
            this.btnDRight.Name = "btnDRight";
            this.btnDRight.Size = new System.Drawing.Size(75, 34);
            this.btnDRight.TabIndex = 4;
            this.btnDRight.Text = ">>";
            this.btnDRight.UseVisualStyleBackColor = true;
            this.btnDRight.Click += new System.EventHandler(this.btnDRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(383, 305);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 34);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDLeft
            // 
            this.btnDLeft.Location = new System.Drawing.Point(383, 351);
            this.btnDLeft.Name = "btnDLeft";
            this.btnDLeft.Size = new System.Drawing.Size(75, 34);
            this.btnDLeft.TabIndex = 6;
            this.btnDLeft.Text = "<<";
            this.btnDLeft.UseVisualStyleBackColor = true;
            this.btnDLeft.Click += new System.EventHandler(this.btnDLeft_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.comboBox1.Location = new System.Drawing.Point(484, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 506);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.gbBclass);
            this.Controls.Add(this.gbAclass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(878, 553);
            this.MinimumSize = new System.Drawing.Size(878, 553);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbAclass.ResumeLayout(false);
            this.gbBclass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAclass;
        private System.Windows.Forms.GroupBox gbBclass;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.ListBox LbAclass;
        private System.Windows.Forms.ListBox LbBclass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDLeft;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

