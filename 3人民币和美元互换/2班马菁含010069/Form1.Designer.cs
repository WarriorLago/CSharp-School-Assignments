namespace _2班马菁含010069
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRmb = new System.Windows.Forms.Label();
            this.lbHuilv = new System.Windows.Forms.Label();
            this.lbDollar = new System.Windows.Forms.Label();
            this.txtRmb = new System.Windows.Forms.TextBox();
            this.txtHuilv = new System.Windows.Forms.TextBox();
            this.txtDollar = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnR2D = new System.Windows.Forms.Button();
            this.btnD2R = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRmb
            // 
            this.lbRmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRmb.AutoSize = true;
            this.lbRmb.Location = new System.Drawing.Point(124, 63);
            this.lbRmb.Name = "lbRmb";
            this.lbRmb.Size = new System.Drawing.Size(82, 24);
            this.lbRmb.TabIndex = 0;
            this.lbRmb.Text = "人民币";
            // 
            // lbHuilv
            // 
            this.lbHuilv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHuilv.AutoSize = true;
            this.lbHuilv.Location = new System.Drawing.Point(344, 63);
            this.lbHuilv.Name = "lbHuilv";
            this.lbHuilv.Size = new System.Drawing.Size(58, 24);
            this.lbHuilv.TabIndex = 1;
            this.lbHuilv.Text = "汇率";
            // 
            // lbDollar
            // 
            this.lbDollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDollar.AutoSize = true;
            this.lbDollar.Location = new System.Drawing.Point(549, 63);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(58, 24);
            this.lbDollar.TabIndex = 2;
            this.lbDollar.Text = "美元";
            // 
            // txtRmb
            // 
            this.txtRmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRmb.Location = new System.Drawing.Point(100, 126);
            this.txtRmb.Name = "txtRmb";
            this.txtRmb.Size = new System.Drawing.Size(132, 35);
            this.txtRmb.TabIndex = 3;
            // 
            // txtHuilv
            // 
            this.txtHuilv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHuilv.Location = new System.Drawing.Point(305, 126);
            this.txtHuilv.Name = "txtHuilv";
            this.txtHuilv.Size = new System.Drawing.Size(145, 35);
            this.txtHuilv.TabIndex = 4;
            // 
            // txtDollar
            // 
            this.txtDollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDollar.Location = new System.Drawing.Point(501, 126);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(161, 35);
            this.txtDollar.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(51, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 52);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清屏";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnR2D
            // 
            this.btnR2D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnR2D.Location = new System.Drawing.Point(212, 254);
            this.btnR2D.Name = "btnR2D";
            this.btnR2D.Size = new System.Drawing.Size(163, 52);
            this.btnR2D.TabIndex = 8;
            this.btnR2D.Text = "人民币换美元";
            this.btnR2D.UseVisualStyleBackColor = true;
            this.btnR2D.Click += new System.EventHandler(this.btnR2D_Click);
            // 
            // btnD2R
            // 
            this.btnD2R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnD2R.Location = new System.Drawing.Point(392, 254);
            this.btnD2R.Name = "btnD2R";
            this.btnD2R.Size = new System.Drawing.Size(166, 52);
            this.btnD2R.TabIndex = 9;
            this.btnD2R.Text = "美元换人民币";
            this.btnD2R.UseVisualStyleBackColor = true;
            this.btnD2R.Click += new System.EventHandler(this.btnD2R_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(576, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 52);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 395);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnD2R);
            this.Controls.Add(this.btnR2D);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDollar);
            this.Controls.Add(this.txtHuilv);
            this.Controls.Add(this.txtRmb);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.lbHuilv);
            this.Controls.Add(this.lbRmb);
            this.Name = "Form1";
            this.Text = "人民币与美元兑换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRmb;
        private System.Windows.Forms.Label lbHuilv;
        private System.Windows.Forms.Label lbDollar;
        private System.Windows.Forms.TextBox txtRmb;
        private System.Windows.Forms.TextBox txtHuilv;
        private System.Windows.Forms.TextBox txtDollar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnR2D;
        private System.Windows.Forms.Button btnD2R;
        private System.Windows.Forms.Button btnExit;
    }
}

