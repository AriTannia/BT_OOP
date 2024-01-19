namespace BT6_Chuong3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbListb = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.gbXLLB = new System.Windows.Forms.GroupBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnRBB = new System.Windows.Forms.Button();
            this.btnUL2 = new System.Windows.Forms.Button();
            this.btnDDC = new System.Windows.Forms.Button();
            this.btnDFL = new System.Windows.Forms.Button();
            this.btnAllE = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbListb.SuspendLayout();
            this.gbXLLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LISTBOX";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbListb
            // 
            this.gbListb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListb.Controls.Add(this.listBox1);
            this.gbListb.Controls.Add(this.txtNhap);
            this.gbListb.Controls.Add(this.btnNhap);
            this.gbListb.Location = new System.Drawing.Point(12, 90);
            this.gbListb.Name = "gbListb";
            this.gbListb.Size = new System.Drawing.Size(234, 384);
            this.gbListb.TabIndex = 1;
            this.gbListb.TabStop = false;
            this.gbListb.Text = "Listbox";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(15, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(182, 229);
            this.listBox1.TabIndex = 2;
            // 
            // txtNhap
            // 
            this.txtNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(15, 32);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(182, 30);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhap.Location = new System.Drawing.Point(15, 70);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(182, 36);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // gbXLLB
            // 
            this.gbXLLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbXLLB.Controls.Add(this.btnCE);
            this.gbXLLB.Controls.Add(this.btnCO);
            this.gbXLLB.Controls.Add(this.btnRBB);
            this.gbXLLB.Controls.Add(this.btnUL2);
            this.gbXLLB.Controls.Add(this.btnDDC);
            this.gbXLLB.Controls.Add(this.btnDFL);
            this.gbXLLB.Controls.Add(this.btnAllE);
            this.gbXLLB.Location = new System.Drawing.Point(252, 90);
            this.gbXLLB.Name = "gbXLLB";
            this.gbXLLB.Size = new System.Drawing.Size(218, 384);
            this.gbXLLB.TabIndex = 2;
            this.gbXLLB.TabStop = false;
            this.gbXLLB.Text = "Xử lý Listbox";
            // 
            // btnCE
            // 
            this.btnCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(6, 326);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(203, 40);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "Chọn số lẻ";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnCO
            // 
            this.btnCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.Location = new System.Drawing.Point(6, 277);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(203, 40);
            this.btnCO.TabIndex = 5;
            this.btnCO.Text = "Chọn số chẵn";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.btnCO_Click);
            // 
            // btnRBB
            // 
            this.btnRBB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBB.Location = new System.Drawing.Point(6, 228);
            this.btnRBB.Name = "btnRBB";
            this.btnRBB.Size = new System.Drawing.Size(203, 40);
            this.btnRBB.TabIndex = 4;
            this.btnRBB.Text = "Thay bằng bình phương";
            this.btnRBB.UseVisualStyleBackColor = true;
            this.btnRBB.Click += new System.EventHandler(this.btnRBB_Click);
            // 
            // btnUL2
            // 
            this.btnUL2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUL2.Location = new System.Drawing.Point(6, 179);
            this.btnUL2.Name = "btnUL2";
            this.btnUL2.Size = new System.Drawing.Size(203, 40);
            this.btnUL2.TabIndex = 3;
            this.btnUL2.Text = "Tăng mỗi phần tử lên 2";
            this.btnUL2.UseVisualStyleBackColor = true;
            this.btnUL2.Click += new System.EventHandler(this.btnUL2_Click);
            // 
            // btnDDC
            // 
            this.btnDDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDC.Location = new System.Drawing.Point(6, 130);
            this.btnDDC.Name = "btnDDC";
            this.btnDDC.Size = new System.Drawing.Size(203, 40);
            this.btnDDC.TabIndex = 2;
            this.btnDDC.Text = "Xóa Phần tử đang chọn";
            this.btnDDC.UseVisualStyleBackColor = true;
            this.btnDDC.Click += new System.EventHandler(this.btnDDC_Click);
            // 
            // btnDFL
            // 
            this.btnDFL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFL.Location = new System.Drawing.Point(6, 81);
            this.btnDFL.Name = "btnDFL";
            this.btnDFL.Size = new System.Drawing.Size(203, 40);
            this.btnDFL.TabIndex = 1;
            this.btnDFL.Text = "Xóa Phần tử đầu và cuối";
            this.btnDFL.UseVisualStyleBackColor = true;
            this.btnDFL.Click += new System.EventHandler(this.btnDFL_Click);
            // 
            // btnAllE
            // 
            this.btnAllE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllE.Location = new System.Drawing.Point(6, 32);
            this.btnAllE.Name = "btnAllE";
            this.btnAllE.Size = new System.Drawing.Size(203, 40);
            this.btnAllE.TabIndex = 0;
            this.btnAllE.Text = "Tổng các phần tử trong List";
            this.btnAllE.UseVisualStyleBackColor = true;
            this.btnAllE.Click += new System.EventHandler(this.btnAllE_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(21, 480);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(440, 36);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "&Kết Thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 528);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.gbXLLB);
            this.Controls.Add(this.gbListb);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(500, 575);
            this.Name = "Form1";
            this.Text = "frmListbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbListb.ResumeLayout(false);
            this.gbListb.PerformLayout();
            this.gbXLLB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbListb;
        private System.Windows.Forms.GroupBox gbXLLB;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnRBB;
        private System.Windows.Forms.Button btnUL2;
        private System.Windows.Forms.Button btnDDC;
        private System.Windows.Forms.Button btnDFL;
        private System.Windows.Forms.Button btnAllE;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

