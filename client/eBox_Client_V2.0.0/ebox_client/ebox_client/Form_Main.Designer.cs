﻿namespace ebox_client
{
    partial class Form_Main
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
            this.statusStrip_Top = new System.Windows.Forms.StatusStrip();
            this.toolStrip_bottom = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_findKD = new System.Windows.Forms.Button();
            this.button_SendKD = new System.Windows.Forms.Button();
            this.button_getKD = new System.Windows.Forms.Button();
            this.tabControl_menu = new System.Windows.Forms.TabControl();
            this.tabPage_GetKD = new System.Windows.Forms.TabPage();
            this.label_GetKD_Status = new System.Windows.Forms.Label();
            this.button_GetKD_Cancel = new System.Windows.Forms.Button();
            this.button_GetKDConfirm = new System.Windows.Forms.Button();
            this.textBox_userCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_FindKD = new System.Windows.Forms.TabPage();
            this.label_findStatus = new System.Windows.Forms.Label();
            this.button_FindKD_Cancel = new System.Windows.Forms.Button();
            this.button_FindKD_OK = new System.Windows.Forms.Button();
            this.textBox_usrPH_EXP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Login_man = new System.Windows.Forms.TabPage();
            this.button_pstm_cancel = new System.Windows.Forms.Button();
            this.button_pstm_login = new System.Windows.Forms.Button();
            this.textBox_postm_psw = new System.Windows.Forms.TextBox();
            this.textBox_postm_ph = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_SendKD = new System.Windows.Forms.TabPage();
            this.label_loginStatus = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.textBox_SD_usr_name = new System.Windows.Forms.TextBox();
            this.button_SendPKG = new System.Windows.Forms.Button();
            this.button_SendPKG_Cancel = new System.Windows.Forms.Button();
            this.textBox_SD_usr_phone = new System.Windows.Forms.TextBox();
            this.textBox_SD_express_No = new System.Windows.Forms.TextBox();
            this.label_SendPKG_status = new System.Windows.Forms.Label();
            this.statusStrip_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_menu.SuspendLayout();
            this.tabPage_GetKD.SuspendLayout();
            this.tabPage_FindKD.SuspendLayout();
            this.tabPage_Login_man.SuspendLayout();
            this.tabPage_SendKD.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Top
            // 
            this.statusStrip_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.statusStrip_Top.Name = "statusStrip_Top";
            this.statusStrip_Top.Size = new System.Drawing.Size(714, 22);
            this.statusStrip_Top.TabIndex = 0;
            this.statusStrip_Top.Text = "statusStrip1";
            // 
            // toolStrip_bottom
            // 
            this.toolStrip_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip_bottom.Location = new System.Drawing.Point(0, 396);
            this.toolStrip_bottom.Name = "toolStrip_bottom";
            this.toolStrip_bottom.Size = new System.Drawing.Size(714, 25);
            this.toolStrip_bottom.TabIndex = 1;
            this.toolStrip_bottom.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Help);
            this.panel1.Controls.Add(this.button_findKD);
            this.panel1.Controls.Add(this.button_SendKD);
            this.panel1.Controls.Add(this.button_getKD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 59);
            this.panel1.TabIndex = 2;
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(501, 3);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(75, 53);
            this.button_Help.TabIndex = 3;
            this.button_Help.Text = "帮助信息";
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // button_findKD
            // 
            this.button_findKD.Location = new System.Drawing.Point(358, 3);
            this.button_findKD.Name = "button_findKD";
            this.button_findKD.Size = new System.Drawing.Size(75, 53);
            this.button_findKD.TabIndex = 2;
            this.button_findKD.Text = "快件查询";
            this.button_findKD.UseVisualStyleBackColor = true;
            this.button_findKD.Click += new System.EventHandler(this.button_findKD_Click);
            // 
            // button_SendKD
            // 
            this.button_SendKD.Location = new System.Drawing.Point(224, 3);
            this.button_SendKD.Name = "button_SendKD";
            this.button_SendKD.Size = new System.Drawing.Size(75, 53);
            this.button_SendKD.TabIndex = 1;
            this.button_SendKD.Text = "投快件";
            this.button_SendKD.UseVisualStyleBackColor = true;
            this.button_SendKD.Click += new System.EventHandler(this.button_SendKD_Click);
            // 
            // button_getKD
            // 
            this.button_getKD.Location = new System.Drawing.Point(96, 3);
            this.button_getKD.Name = "button_getKD";
            this.button_getKD.Size = new System.Drawing.Size(75, 53);
            this.button_getKD.TabIndex = 0;
            this.button_getKD.Text = "取快件";
            this.button_getKD.UseVisualStyleBackColor = true;
            this.button_getKD.Click += new System.EventHandler(this.button_getKD_Click);
            // 
            // tabControl_menu
            // 
            this.tabControl_menu.Controls.Add(this.tabPage_GetKD);
            this.tabControl_menu.Controls.Add(this.tabPage_FindKD);
            this.tabControl_menu.Controls.Add(this.tabPage_Login_man);
            this.tabControl_menu.Controls.Add(this.tabPage_SendKD);
            this.tabControl_menu.Location = new System.Drawing.Point(96, 43);
            this.tabControl_menu.Name = "tabControl_menu";
            this.tabControl_menu.SelectedIndex = 0;
            this.tabControl_menu.Size = new System.Drawing.Size(492, 263);
            this.tabControl_menu.TabIndex = 3;
            // 
            // tabPage_GetKD
            // 
            this.tabPage_GetKD.Controls.Add(this.label_GetKD_Status);
            this.tabPage_GetKD.Controls.Add(this.button_GetKD_Cancel);
            this.tabPage_GetKD.Controls.Add(this.button_GetKDConfirm);
            this.tabPage_GetKD.Controls.Add(this.textBox_userCode);
            this.tabPage_GetKD.Controls.Add(this.label2);
            this.tabPage_GetKD.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GetKD.Name = "tabPage_GetKD";
            this.tabPage_GetKD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GetKD.Size = new System.Drawing.Size(484, 237);
            this.tabPage_GetKD.TabIndex = 0;
            this.tabPage_GetKD.Text = "取快件";
            this.tabPage_GetKD.UseVisualStyleBackColor = true;
            // 
            // label_GetKD_Status
            // 
            this.label_GetKD_Status.AutoSize = true;
            this.label_GetKD_Status.Location = new System.Drawing.Point(42, 124);
            this.label_GetKD_Status.Name = "label_GetKD_Status";
            this.label_GetKD_Status.Size = new System.Drawing.Size(41, 12);
            this.label_GetKD_Status.TabIndex = 4;
            this.label_GetKD_Status.Text = "label3";
            // 
            // button_GetKD_Cancel
            // 
            this.button_GetKD_Cancel.Location = new System.Drawing.Point(385, 72);
            this.button_GetKD_Cancel.Name = "button_GetKD_Cancel";
            this.button_GetKD_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_GetKD_Cancel.TabIndex = 3;
            this.button_GetKD_Cancel.Text = "取消";
            this.button_GetKD_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_GetKDConfirm
            // 
            this.button_GetKDConfirm.Location = new System.Drawing.Point(288, 72);
            this.button_GetKDConfirm.Name = "button_GetKDConfirm";
            this.button_GetKDConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_GetKDConfirm.TabIndex = 2;
            this.button_GetKDConfirm.Text = "确定";
            this.button_GetKDConfirm.UseVisualStyleBackColor = true;
            this.button_GetKDConfirm.Click += new System.EventHandler(this.button_GetKDConfirm_Click);
            // 
            // textBox_userCode
            // 
            this.textBox_userCode.Location = new System.Drawing.Point(135, 75);
            this.textBox_userCode.Name = "textBox_userCode";
            this.textBox_userCode.Size = new System.Drawing.Size(118, 21);
            this.textBox_userCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入提取码：";
            // 
            // tabPage_FindKD
            // 
            this.tabPage_FindKD.Controls.Add(this.label_findStatus);
            this.tabPage_FindKD.Controls.Add(this.button_FindKD_Cancel);
            this.tabPage_FindKD.Controls.Add(this.button_FindKD_OK);
            this.tabPage_FindKD.Controls.Add(this.textBox_usrPH_EXP);
            this.tabPage_FindKD.Controls.Add(this.label1);
            this.tabPage_FindKD.Location = new System.Drawing.Point(4, 22);
            this.tabPage_FindKD.Name = "tabPage_FindKD";
            this.tabPage_FindKD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FindKD.Size = new System.Drawing.Size(484, 237);
            this.tabPage_FindKD.TabIndex = 1;
            this.tabPage_FindKD.Text = "快件查询";
            this.tabPage_FindKD.UseVisualStyleBackColor = true;
            // 
            // label_findStatus
            // 
            this.label_findStatus.AutoSize = true;
            this.label_findStatus.Location = new System.Drawing.Point(36, 113);
            this.label_findStatus.Name = "label_findStatus";
            this.label_findStatus.Size = new System.Drawing.Size(41, 12);
            this.label_findStatus.TabIndex = 9;
            this.label_findStatus.Text = "label2";
            // 
            // button_FindKD_Cancel
            // 
            this.button_FindKD_Cancel.Location = new System.Drawing.Point(374, 58);
            this.button_FindKD_Cancel.Name = "button_FindKD_Cancel";
            this.button_FindKD_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_FindKD_Cancel.TabIndex = 8;
            this.button_FindKD_Cancel.Text = "取消";
            this.button_FindKD_Cancel.UseVisualStyleBackColor = true;
            this.button_FindKD_Cancel.Click += new System.EventHandler(this.button_FindKD_Cancel_Click);
            // 
            // button_FindKD_OK
            // 
            this.button_FindKD_OK.Location = new System.Drawing.Point(279, 58);
            this.button_FindKD_OK.Name = "button_FindKD_OK";
            this.button_FindKD_OK.Size = new System.Drawing.Size(75, 23);
            this.button_FindKD_OK.TabIndex = 7;
            this.button_FindKD_OK.Text = "确定";
            this.button_FindKD_OK.UseVisualStyleBackColor = true;
            this.button_FindKD_OK.Click += new System.EventHandler(this.button_FindKD_OK_Click);
            // 
            // textBox_usrPH_EXP
            // 
            this.textBox_usrPH_EXP.Location = new System.Drawing.Point(142, 61);
            this.textBox_usrPH_EXP.Name = "textBox_usrPH_EXP";
            this.textBox_usrPH_EXP.Size = new System.Drawing.Size(120, 21);
            this.textBox_usrPH_EXP.TabIndex = 6;
            this.textBox_usrPH_EXP.Text = "17097228601";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "运单号或手机号：";
            // 
            // tabPage_Login_man
            // 
            this.tabPage_Login_man.Controls.Add(this.label_loginStatus);
            this.tabPage_Login_man.Controls.Add(this.button_pstm_cancel);
            this.tabPage_Login_man.Controls.Add(this.button_pstm_login);
            this.tabPage_Login_man.Controls.Add(this.textBox_postm_psw);
            this.tabPage_Login_man.Controls.Add(this.textBox_postm_ph);
            this.tabPage_Login_man.Controls.Add(this.label4);
            this.tabPage_Login_man.Controls.Add(this.label3);
            this.tabPage_Login_man.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Login_man.Name = "tabPage_Login_man";
            this.tabPage_Login_man.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Login_man.Size = new System.Drawing.Size(484, 237);
            this.tabPage_Login_man.TabIndex = 2;
            this.tabPage_Login_man.Text = "投快件_登陆";
            this.tabPage_Login_man.UseVisualStyleBackColor = true;
            // 
            // button_pstm_cancel
            // 
            this.button_pstm_cancel.Location = new System.Drawing.Point(272, 156);
            this.button_pstm_cancel.Name = "button_pstm_cancel";
            this.button_pstm_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_pstm_cancel.TabIndex = 5;
            this.button_pstm_cancel.Text = "取消";
            this.button_pstm_cancel.UseVisualStyleBackColor = true;
            // 
            // button_pstm_login
            // 
            this.button_pstm_login.Location = new System.Drawing.Point(148, 156);
            this.button_pstm_login.Name = "button_pstm_login";
            this.button_pstm_login.Size = new System.Drawing.Size(75, 23);
            this.button_pstm_login.TabIndex = 4;
            this.button_pstm_login.Text = "登陆";
            this.button_pstm_login.UseVisualStyleBackColor = true;
            this.button_pstm_login.Click += new System.EventHandler(this.button_pstm_login_Click);
            // 
            // textBox_postm_psw
            // 
            this.textBox_postm_psw.Location = new System.Drawing.Point(148, 100);
            this.textBox_postm_psw.Name = "textBox_postm_psw";
            this.textBox_postm_psw.Size = new System.Drawing.Size(123, 21);
            this.textBox_postm_psw.TabIndex = 3;
            // 
            // textBox_postm_ph
            // 
            this.textBox_postm_ph.Location = new System.Drawing.Point(148, 52);
            this.textBox_postm_ph.Name = "textBox_postm_ph";
            this.textBox_postm_ph.Size = new System.Drawing.Size(123, 21);
            this.textBox_postm_ph.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "快递员手机号：";
            // 
            // tabPage_SendKD
            // 
            this.tabPage_SendKD.Controls.Add(this.label_SendPKG_status);
            this.tabPage_SendKD.Controls.Add(this.textBox_SD_express_No);
            this.tabPage_SendKD.Controls.Add(this.textBox_SD_usr_phone);
            this.tabPage_SendKD.Controls.Add(this.button_SendPKG_Cancel);
            this.tabPage_SendKD.Controls.Add(this.button_SendPKG);
            this.tabPage_SendKD.Controls.Add(this.textBox_SD_usr_name);
            this.tabPage_SendKD.Controls.Add(this.comboBox_size);
            this.tabPage_SendKD.Controls.Add(this.label8);
            this.tabPage_SendKD.Controls.Add(this.label7);
            this.tabPage_SendKD.Controls.Add(this.label6);
            this.tabPage_SendKD.Controls.Add(this.label5);
            this.tabPage_SendKD.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SendKD.Name = "tabPage_SendKD";
            this.tabPage_SendKD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SendKD.Size = new System.Drawing.Size(484, 237);
            this.tabPage_SendKD.TabIndex = 3;
            this.tabPage_SendKD.Text = "投快件";
            this.tabPage_SendKD.UseVisualStyleBackColor = true;
            // 
            // label_loginStatus
            // 
            this.label_loginStatus.AutoSize = true;
            this.label_loginStatus.Location = new System.Drawing.Point(306, 103);
            this.label_loginStatus.Name = "label_loginStatus";
            this.label_loginStatus.Size = new System.Drawing.Size(41, 12);
            this.label_loginStatus.TabIndex = 6;
            this.label_loginStatus.Text = "label5";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "收件人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "手机号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "运单号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "箱子规格：";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "小",
            "普通",
            "大"});
            this.comboBox_size.Location = new System.Drawing.Point(133, 153);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(128, 20);
            this.comboBox_size.TabIndex = 4;
            this.comboBox_size.Text = "普通";
            // 
            // textBox_SD_usr_name
            // 
            this.textBox_SD_usr_name.Location = new System.Drawing.Point(133, 115);
            this.textBox_SD_usr_name.Name = "textBox_SD_usr_name";
            this.textBox_SD_usr_name.Size = new System.Drawing.Size(128, 21);
            this.textBox_SD_usr_name.TabIndex = 5;
            this.textBox_SD_usr_name.Text = "王";
            // 
            // button_SendPKG
            // 
            this.button_SendPKG.Location = new System.Drawing.Point(161, 192);
            this.button_SendPKG.Name = "button_SendPKG";
            this.button_SendPKG.Size = new System.Drawing.Size(75, 23);
            this.button_SendPKG.TabIndex = 6;
            this.button_SendPKG.Text = "投递";
            this.button_SendPKG.UseVisualStyleBackColor = true;
            this.button_SendPKG.Click += new System.EventHandler(this.button_SendPKG_Click);
            // 
            // button_SendPKG_Cancel
            // 
            this.button_SendPKG_Cancel.Location = new System.Drawing.Point(273, 192);
            this.button_SendPKG_Cancel.Name = "button_SendPKG_Cancel";
            this.button_SendPKG_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_SendPKG_Cancel.TabIndex = 7;
            this.button_SendPKG_Cancel.Text = "取消";
            this.button_SendPKG_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_SD_usr_phone
            // 
            this.textBox_SD_usr_phone.Location = new System.Drawing.Point(133, 42);
            this.textBox_SD_usr_phone.Name = "textBox_SD_usr_phone";
            this.textBox_SD_usr_phone.Size = new System.Drawing.Size(128, 21);
            this.textBox_SD_usr_phone.TabIndex = 8;
            this.textBox_SD_usr_phone.Text = "17097228602";
            // 
            // textBox_SD_express_No
            // 
            this.textBox_SD_express_No.Location = new System.Drawing.Point(133, 79);
            this.textBox_SD_express_No.Name = "textBox_SD_express_No";
            this.textBox_SD_express_No.Size = new System.Drawing.Size(128, 21);
            this.textBox_SD_express_No.TabIndex = 9;
            this.textBox_SD_express_No.Text = "EMS000011";
            // 
            // label_SendPKG_status
            // 
            this.label_SendPKG_status.AutoSize = true;
            this.label_SendPKG_status.Location = new System.Drawing.Point(292, 156);
            this.label_SendPKG_status.Name = "label_SendPKG_status";
            this.label_SendPKG_status.Size = new System.Drawing.Size(41, 12);
            this.label_SendPKG_status.TabIndex = 10;
            this.label_SendPKG_status.Text = "label9";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 421);
            this.Controls.Add(this.tabControl_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip_bottom);
            this.Controls.Add(this.statusStrip_Top);
            this.Name = "Form_Main";
            this.Text = "ebox system";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.statusStrip_Top.ResumeLayout(false);
            this.statusStrip_Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl_menu.ResumeLayout(false);
            this.tabPage_GetKD.ResumeLayout(false);
            this.tabPage_GetKD.PerformLayout();
            this.tabPage_FindKD.ResumeLayout(false);
            this.tabPage_FindKD.PerformLayout();
            this.tabPage_Login_man.ResumeLayout(false);
            this.tabPage_Login_man.PerformLayout();
            this.tabPage_SendKD.ResumeLayout(false);
            this.tabPage_SendKD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Top;
        private System.Windows.Forms.ToolStrip toolStrip_bottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_findKD;
        private System.Windows.Forms.Button button_SendKD;
        private System.Windows.Forms.Button button_getKD;
        private System.Windows.Forms.TabControl tabControl_menu;
        private System.Windows.Forms.TabPage tabPage_GetKD;
        private System.Windows.Forms.TabPage tabPage_FindKD;
        private System.Windows.Forms.TabPage tabPage_Login_man;
        private System.Windows.Forms.TabPage tabPage_SendKD;
        private System.Windows.Forms.Label label_findStatus;
        private System.Windows.Forms.Button button_FindKD_Cancel;
        private System.Windows.Forms.Button button_FindKD_OK;
        private System.Windows.Forms.TextBox textBox_usrPH_EXP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GetKDConfirm;
        private System.Windows.Forms.TextBox textBox_userCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GetKD_Cancel;
        private System.Windows.Forms.Label label_GetKD_Status;
        private System.Windows.Forms.TextBox textBox_postm_psw;
        private System.Windows.Forms.TextBox textBox_postm_ph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_pstm_cancel;
        private System.Windows.Forms.Button button_pstm_login;
        private System.Windows.Forms.Label label_loginStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_SendPKG_Cancel;
        private System.Windows.Forms.Button button_SendPKG;
        private System.Windows.Forms.TextBox textBox_SD_usr_name;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_SD_express_No;
        private System.Windows.Forms.TextBox textBox_SD_usr_phone;
        private System.Windows.Forms.Label label_SendPKG_status;
    }
}

