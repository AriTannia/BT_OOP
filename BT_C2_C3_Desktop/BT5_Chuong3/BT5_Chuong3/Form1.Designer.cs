namespace BT5_Chuong3
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
            this.txtKhaiBao = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.DispKB = new System.Windows.Forms.Label();
            this.btnDLast = new System.Windows.Forms.Button();
            this.btnDAll = new System.Windows.Forms.Button();
            this.btnDFirst = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKhaiBao
            // 
            this.txtKhaiBao.BackColor = System.Drawing.Color.Fuchsia;
            this.txtKhaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhaiBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtKhaiBao.Location = new System.Drawing.Point(-2, 4);
            this.txtKhaiBao.Name = "txtKhaiBao";
            this.txtKhaiBao.Size = new System.Drawing.Size(804, 92);
            this.txtKhaiBao.TabIndex = 0;
            this.txtKhaiBao.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            this.txtKhaiBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 99);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInput);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.lblHoTen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.DispKB);
            this.splitContainer1.Panel2.Controls.Add(this.btnDLast);
            this.splitContainer1.Panel2.Controls.Add(this.btnDAll);
            this.splitContainer1.Panel2.Controls.Add(this.btnDFirst);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteC);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Size = new System.Drawing.Size(803, 419);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(61, 136);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(148, 33);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Nhập thông tin";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(114, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(25, 85);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(69, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // DispKB
            // 
            this.DispKB.BackColor = System.Drawing.Color.White;
            this.DispKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispKB.Location = new System.Drawing.Point(247, 267);
            this.DispKB.Name = "DispKB";
            this.DispKB.Size = new System.Drawing.Size(176, 31);
            this.DispKB.TabIndex = 0;
            this.DispKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDLast
            // 
            this.btnDLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDLast.Location = new System.Drawing.Point(271, 373);
            this.btnDLast.Name = "btnDLast";
            this.btnDLast.Size = new System.Drawing.Size(182, 33);
            this.btnDLast.TabIndex = 6;
            this.btnDLast.Text = "Xóa thông tin cuối";
            this.btnDLast.UseVisualStyleBackColor = true;
            this.btnDLast.Click += new System.EventHandler(this.btnDLast_Click);
            // 
            // btnDAll
            // 
            this.btnDAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAll.Location = new System.Drawing.Point(41, 373);
            this.btnDAll.Name = "btnDAll";
            this.btnDAll.Size = new System.Drawing.Size(205, 33);
            this.btnDAll.TabIndex = 5;
            this.btnDAll.Text = "Xóa tất cả thông tin";
            this.btnDAll.UseVisualStyleBackColor = true;
            this.btnDAll.Click += new System.EventHandler(this.btnDAll_Click);
            // 
            // btnDFirst
            // 
            this.btnDFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFirst.Location = new System.Drawing.Point(271, 323);
            this.btnDFirst.Name = "btnDFirst";
            this.btnDFirst.Size = new System.Drawing.Size(182, 31);
            this.btnDFirst.TabIndex = 4;
            this.btnDFirst.Text = "Xóa thông tin đầu";
            this.btnDFirst.UseVisualStyleBackColor = true;
            this.btnDFirst.Click += new System.EventHandler(this.btnDFirst_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.AutoEllipsis = true;
            this.btnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteC.Location = new System.Drawing.Point(41, 323);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(205, 31);
            this.btnDeleteC.TabIndex = 3;
            this.btnDeleteC.Text = "Xóa thông tin đang chọn";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(38, 273);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 18);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng số người đã khai báo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 16);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(459, 220);
            this.checkedListBox1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtKhaiBao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtKhaiBao;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnDLast;
        private System.Windows.Forms.Button btnDAll;
        private System.Windows.Forms.Button btnDFirst;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label DispKB;
    }
}

