namespace _21计科2班_马菁含069
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.btn_transform = new System.Windows.Forms.Button();
            this.before_jinzhi = new System.Windows.Forms.ComboBox();
            this.after_jinzhi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入一个数字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "该数字是几进制";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(48, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "希望变成几进制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(48, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "转化后的结果为";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num.Location = new System.Drawing.Point(371, 48);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(179, 41);
            this.num.TabIndex = 4;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(371, 377);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(179, 41);
            this.result.TabIndex = 5;
            // 
            // btn_transform
            // 
            this.btn_transform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_transform.Location = new System.Drawing.Point(234, 288);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(171, 61);
            this.btn_transform.TabIndex = 6;
            this.btn_transform.Text = "转换";
            this.btn_transform.UseVisualStyleBackColor = false;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // before_jinzhi
            // 
            this.before_jinzhi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.before_jinzhi.FormattingEnabled = true;
            this.before_jinzhi.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.before_jinzhi.Location = new System.Drawing.Point(371, 131);
            this.before_jinzhi.Name = "before_jinzhi";
            this.before_jinzhi.Size = new System.Drawing.Size(179, 41);
            this.before_jinzhi.TabIndex = 7;
            // 
            // after_jinzhi
            // 
            this.after_jinzhi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.after_jinzhi.FormattingEnabled = true;
            this.after_jinzhi.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.after_jinzhi.Location = new System.Drawing.Point(371, 212);
            this.after_jinzhi.Name = "after_jinzhi";
            this.after_jinzhi.Size = new System.Drawing.Size(179, 41);
            this.after_jinzhi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 481);
            this.Controls.Add(this.after_jinzhi);
            this.Controls.Add(this.before_jinzhi);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "进制转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.ComboBox before_jinzhi;
        private System.Windows.Forms.ComboBox after_jinzhi;
    }
}

