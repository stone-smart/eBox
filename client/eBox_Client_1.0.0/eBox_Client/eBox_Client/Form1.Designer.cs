namespace eBox_Client
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.statusStrip_Top = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SendKD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Bottom
            // 
            this.statusStrip_Bottom.Location = new System.Drawing.Point(0, 676);
            this.statusStrip_Bottom.Name = "statusStrip_Bottom";
            this.statusStrip_Bottom.Size = new System.Drawing.Size(1174, 22);
            this.statusStrip_Bottom.TabIndex = 1;
            this.statusStrip_Bottom.Text = "statusStrip1";
            // 
            // statusStrip_Top
            // 
            this.statusStrip_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.statusStrip_Top.Name = "statusStrip_Top";
            this.statusStrip_Top.Size = new System.Drawing.Size(1174, 22);
            this.statusStrip_Top.TabIndex = 2;
            this.statusStrip_Top.Text = "statusStrip2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SendKD);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 52);
            this.panel2.TabIndex = 4;
            // 
            // SendKD
            // 
            this.SendKD.Location = new System.Drawing.Point(299, 13);
            this.SendKD.Name = "SendKD";
            this.SendKD.Size = new System.Drawing.Size(75, 23);
            this.SendKD.TabIndex = 1;
            this.SendKD.Text = "投快递";
            this.SendKD.UseVisualStyleBackColor = true;
            this.SendKD.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(176, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "取快递";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip_Top);
            this.Controls.Add(this.statusStrip_Bottom);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MDF_Father_Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Bottom;
        private System.Windows.Forms.StatusStrip statusStrip_Top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendKD;
    }
}

