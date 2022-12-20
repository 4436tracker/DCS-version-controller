namespace DCS_版本转换
{
    partial class DCSConvert
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
            this.buttonStable = new System.Windows.Forms.Button();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.textBoxCustomVersion = new System.Windows.Forms.TextBox();
            this.labelversion1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCustomVersion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStable
            // 
            this.buttonStable.Location = new System.Drawing.Point(124, 14);
            this.buttonStable.Name = "buttonStable";
            this.buttonStable.Size = new System.Drawing.Size(120, 51);
            this.buttonStable.TabIndex = 3;
            this.buttonStable.Text = "切为测试版";
            this.buttonStable.UseVisualStyleBackColor = true;
            this.buttonStable.Click += new System.EventHandler(this.buttonStable_Click);
            // 
            // buttonRelease
            // 
            this.buttonRelease.Location = new System.Drawing.Point(289, 14);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(120, 51);
            this.buttonRelease.TabIndex = 4;
            this.buttonRelease.Text = "切为稳定版";
            this.buttonRelease.UseVisualStyleBackColor = true;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // textBoxCustomVersion
            // 
            this.textBoxCustomVersion.Location = new System.Drawing.Point(124, 73);
            this.textBoxCustomVersion.Name = "textBoxCustomVersion";
            this.textBoxCustomVersion.Size = new System.Drawing.Size(159, 21);
            this.textBoxCustomVersion.TabIndex = 6;
            // 
            // labelversion1
            // 
            this.labelversion1.AutoSize = true;
            this.labelversion1.Location = new System.Drawing.Point(12, 33);
            this.labelversion1.Name = "labelversion1";
            this.labelversion1.Size = new System.Drawing.Size(65, 12);
            this.labelversion1.TabIndex = 7;
            this.labelversion1.Text = "快捷切换：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "切换为自定义版本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "请在上方输入想要切换的版本\r\n例如：2.5.6，2.7或2.8";
            // 
            // buttonCustomVersion
            // 
            this.buttonCustomVersion.Location = new System.Drawing.Point(289, 70);
            this.buttonCustomVersion.Name = "buttonCustomVersion";
            this.buttonCustomVersion.Size = new System.Drawing.Size(120, 51);
            this.buttonCustomVersion.TabIndex = 10;
            this.buttonCustomVersion.Text = "切为自定义版本";
            this.buttonCustomVersion.UseVisualStyleBackColor = true;
            this.buttonCustomVersion.Click += new System.EventHandler(this.buttonCustomVersion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "DCS修复：";
            // 
            // buttonFix
            // 
            this.buttonFix.Location = new System.Drawing.Point(124, 128);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(283, 51);
            this.buttonFix.TabIndex = 12;
            this.buttonFix.Text = "修复DCS";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // DCSConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 192);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCustomVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelversion1);
            this.Controls.Add(this.textBoxCustomVersion);
            this.Controls.Add(this.buttonRelease);
            this.Controls.Add(this.buttonStable);
            this.Name = "DCSConvert";
            this.Text = "官网版DCS版本转换(by:4436/tracker)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStable;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.TextBox textBoxCustomVersion;
        private System.Windows.Forms.Label labelversion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCustomVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFix;
    }
}

