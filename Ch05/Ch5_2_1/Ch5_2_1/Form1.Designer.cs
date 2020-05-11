namespace Ch5_2_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTemp.Location = new System.Drawing.Point(13, 51);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(217, 40);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "輸入溫度：";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTemp.Location = new System.Drawing.Point(207, 38);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(193, 53);
            this.txtTemp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(455, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "判斷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.Window;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("宋体", 12F);
            this.lblOutput.Location = new System.Drawing.Point(27, 140);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(738, 200);
            this.lblOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Name = "Form1";
            this.Text = "感冒預防器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOutput;
    }
}

