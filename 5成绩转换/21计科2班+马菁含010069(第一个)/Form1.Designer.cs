﻿namespace _21计科2班_马菁含010069_第一个_
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
            this.btn_transform = new System.Windows.Forms.Button();
            this.num_100 = new System.Windows.Forms.TextBox();
            this.num_5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "百分制成绩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "五分制成绩";
            // 
            // btn_transform
            // 
            this.btn_transform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_transform.Location = new System.Drawing.Point(176, 121);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(145, 66);
            this.btn_transform.TabIndex = 2;
            this.btn_transform.Text = "转换";
            this.btn_transform.UseVisualStyleBackColor = false;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // num_100
            // 
            this.num_100.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_100.Location = new System.Drawing.Point(274, 45);
            this.num_100.Name = "num_100";
            this.num_100.Size = new System.Drawing.Size(170, 56);
            this.num_100.TabIndex = 3;
            this.num_100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_100_KeyPress);
            // 
            // num_5
            // 
            this.num_5.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_5.Location = new System.Drawing.Point(274, 213);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(170, 56);
            this.num_5.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 327);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_100);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "成绩转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.TextBox num_100;
        private System.Windows.Forms.TextBox num_5;
    }
}

