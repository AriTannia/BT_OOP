namespace BT2_Chuong3
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
            this.lblTnd = new System.Windows.Forms.Label();
            this.lblMk = new System.Windows.Forms.Label();
            this.txtTnd = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.btnDn = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTnd
            // 
            this.lblTnd.AutoSize = true;
            this.lblTnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnd.Location = new System.Drawing.Point(22, 63);
            this.lblTnd.Name = "lblTnd";
            this.lblTnd.Size = new System.Drawing.Size(123, 20);
            this.lblTnd.TabIndex = 1;
            this.lblTnd.Text = "Tên người dùng";
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMk.Location = new System.Drawing.Point(27, 106);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(77, 20);
            this.lblMk.TabIndex = 2;
            this.lblMk.Text = "Mật khẩu";
            // 
            // txtTnd
            // 
            this.txtTnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnd.Location = new System.Drawing.Point(167, 56);
            this.txtTnd.Name = "txtTnd";
            this.txtTnd.Size = new System.Drawing.Size(266, 30);
            this.txtTnd.TabIndex = 3;
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(167, 99);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '#';
            this.txtMk.Size = new System.Drawing.Size(266, 30);
            this.txtMk.TabIndex = 4;
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(31, 154);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(122, 58);
            this.btnDn.TabIndex = 5;
            this.btnDn.Text = "Đăng Nhập";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(315, 154);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(118, 58);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "Thoát";
            this.lblEnd.UseVisualStyleBackColor = true;
            this.lblEnd.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTnd);
            this.Controls.Add(this.lblMk);
            this.Controls.Add(this.lblTnd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTnd;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.TextBox txtTnd;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button lblEnd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

