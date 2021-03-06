﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ebox_client
{
    public partial class Form_Main : Form
    {
        //数据库连接
        string strcon ="";
        OleDbConnection OleCon=null;
        OleDbCommand OleCom = null;
        OleDbDataReader OleReader = null;

        //登陆人员信息
        string Login_PSTM_phone = "";  //值为空，表示未登陆
        int Login_PSTM_balance=0;//余额
        string Login_Manager_phone = "";
        
        //箱子操作对象
        BoxControl MyBox=null;

        //系统信息
        public string Ebox_No = "";
        public int Box_Num = 0;
        public int Box_Num_used = 0;
        public int Box_Used_amount = 0;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_getKD_Click(object sender, EventArgs e)
        {
            //Show Menu
            tabPage_GetKD.Parent = tabControl_menu;
            tabPage_FindKD.Parent = null;
            tabPage_Login_man.Parent = null;
            tabPage_SendKD.Parent = null;
            tabPage_AddBox.Parent = null;
            tabPage_ManagerLogin.Parent = null;
            tabPage_UpdateBox.Parent = null;


        }

        //投快递——登陆界面
        private void button_SendKD_Click(object sender, EventArgs e)
        {
            //Show Menu
            tabPage_GetKD.Parent = null;
            tabPage_FindKD.Parent = null;
            tabPage_Login_man.Parent = tabControl_menu;
            tabPage_SendKD.Parent = null;
            tabPage_AddBox.Parent = null;
            tabPage_ManagerLogin.Parent = null;
            tabPage_UpdateBox.Parent = null;
        }

        private void button_findKD_Click(object sender, EventArgs e)
        {
            //Show Menu
            tabPage_GetKD.Parent = null;
            tabPage_FindKD.Parent = tabControl_menu;
            tabPage_Login_man.Parent = null;
            tabPage_SendKD.Parent = null;
            tabPage_AddBox.Parent = null;
            tabPage_ManagerLogin.Parent = null;
            tabPage_UpdateBox.Parent = null;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Show Menu
            tabPage_GetKD.Parent = tabControl_menu;
            tabPage_FindKD.Parent = null;
            tabPage_Login_man.Parent = null;
            tabPage_SendKD.Parent = null;
            tabPage_AddBox.Parent = null;
            tabPage_ManagerLogin.Parent = null;
            tabPage_UpdateBox.Parent = null;

            //连接字符串
            strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\database\\ebox.accdb";

            //初始化BoxControl对象
            MyBox = new BoxControl(strcon);

            //初始化系统变量
            Init_System();

            toolStripLabel1.Text = "电子柜编号："+Ebox_No;
            ShowEboxStatus();
        }

        private void ShowEboxStatus()
        {
            toolStripLabel2.Text = "空箱子数：" + (Box_Num - Box_Num_used).ToString() ;
            toolStripLabel3.Text = "存取次数:" + Box_Used_amount.ToString();
        }

        private void Init_System()
        {
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from EBOX_MANAGE";
                OleCom = new OleDbCommand(sql, OleCon);
                OleReader = OleCom.ExecuteReader();
               
                while (OleReader.Read()) //有记录为True
                {
                    Ebox_No = OleReader[1].ToString();
                    Box_Num = Int16.Parse(OleReader[2].ToString());
                    Box_Num_used =Int16.Parse(OleReader[3].ToString());
                    Box_Used_amount = Int16.Parse(OleReader[6].ToString());                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                OleReader.Close();
                OleCon.Close();
            }
        }

        //快件查询
        private void button_FindKD_OK_Click(object sender, EventArgs e)
        {
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from PKG_RECORD where User_phone='" + textBox_usrPH_EXP.Text.Trim() + "' OR Exp_Num='" + textBox_usrPH_EXP.Text.Trim() + "' AND Flag_Taked=false" ;
                OleCom = new OleDbCommand(sql, OleCon);
                OleReader = OleCom.ExecuteReader();

                label_findStatus.Text = "";
                while (OleReader.Read()) //有记录为True
                {
                    label_findStatus.Text += "运单号：" + OleReader[9].ToString() + " 箱子号:" + OleReader[5].ToString() + " 存入时间：" + OleReader[6].ToString() + " 提取时间：" + OleReader[7].ToString() + "\n";                                            
                }
                if (label_findStatus.Text == "")//没有记录
                {
                    label_findStatus.Text = "没有查到您的快件记录，请联系管理员，谢谢！";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                OleReader.Close();
                OleCon.Close();
            }
        }

        private void button_FindKD_Cancel_Click(object sender, EventArgs e)
        {
            textBox_usrPH_EXP.Text = "";
            label_findStatus.Text = "";
        }

        //输入提取码取快递
        private void button_GetKDConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from PKG_RECORD where User_Code='"+ textBox_userCode.Text.Trim() + "' AND Flag_Taked=false";
                OleCom = new OleDbCommand(sql, OleCon);              
                OleReader = OleCom.ExecuteReader();
                label_GetKD_Status.Text = "";
                if (OleReader.Read()) //有记录为True
                {

                    //开箱提示
                    label_GetKD_Status.Text += "运单号：" + OleReader[9].ToString() + " 箱子号:" + OleReader[5].ToString() + " 存入日期：" + OleReader[6].ToString() + "\n";
                    label_GetKD_Status.Text += "\n箱子已打开，请取走您的快件，谢谢!\n";
                    textBox_userCode.Text = "";
                    string ItemNo = OleReader[0].ToString();
                    string BoxID = OleReader[5].ToString();

                    //打开箱门
                    MyBox.OpenBox(BoxID);

                    //语音提示

                    //更新PKG_Log数据库
                    sql = "Update PKG_RECORD Set  PKG_RECORD.Flag_Taked=true,PKG_RECORD.Time_Take=#" + System.DateTime.Now.ToLocalTime().ToString() + "# where PKG_RECORD.No=" + ItemNo;
                    OleCom =new OleDbCommand(sql, OleCon);
                    int PassOk=OleCom.ExecuteNonQuery();
                    Console.WriteLine(PassOk);
                    //更新box_manage数据库，设置对应箱子为空
                    sql = "Update BOX_MANAGE Set  BOX_MANAGE.Empty_State=true,BOX_MANAGE.EBox_No=10000,BOX_MANAGE.Time_update=#" + System.DateTime.Now.ToLocalTime().ToString() + "# where BOX_MANAGE.Box_ID='" + BoxID+"'";
                    OleCom = new OleDbCommand(sql, OleCon);
                    int ReturnVal = OleCom.ExecuteNonQuery();
                    Console.WriteLine(ReturnVal);

                    //更新空箱数
                    Box_Num_used -= 1;
                    Box_Used_amount += 1;
                    ShowEboxStatus();
                }
                else  //没有记录
                {
                    label_GetKD_Status.Text = "提取码错误，请联系管理员，谢谢！";
                }
                OleReader.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {                
                OleCon.Close();
            }
        }

        private void button_pstm_login_Click(object sender, EventArgs e)
        {
            string pstm_phone = textBox_postm_ph.Text.Trim();
            string pstm_psw = textBox_postm_psw.Text.Trim();

            try
            {
                //身份验证
                ebox_webservice.ebox_serviceSoapClient ebox_webserver = new ebox_webservice.ebox_serviceSoapClient();
                Login_PSTM_balance=ebox_webserver.Verify_Postman(pstm_phone, pstm_psw);
                if (Login_PSTM_balance>=0) //验证通过
                {
                    Login_PSTM_phone = pstm_phone;
                    label_loginStatus.Text = "登陆成功..";
                    toolStripStatusLabel1.Text = "快递员：" + Login_PSTM_phone + ", 欢迎您!  余额："+Login_PSTM_balance.ToString();

                    //Show Menu
                    tabPage_GetKD.Parent = null;
                    tabPage_FindKD.Parent = null;
                    tabPage_Login_man.Parent = null;
                    tabPage_SendKD.Parent = tabControl_menu;
                    tabPage_AddBox.Parent = null;
                    tabPage_ManagerLogin.Parent = null;
                    tabPage_UpdateBox.Parent = null;

                    //clear
                    textBox_postm_ph.Text = "";
                    textBox_postm_psw.Text = "";

                }
                else
                {
                    label_loginStatus.Text = "用户名或密码错误，登陆失败！";
                    textBox_postm_psw.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }





        }

        //投快递
        private void button_SendPKG_Click(object sender, EventArgs e)
        {
            string SD_usr_phone = textBox_SD_usr_phone.Text.Trim();
            string SD_exp_no = textBox_SD_express_No.Text.Trim();
            string SD_usr_name = "王";
            string boxDX = comboBox_size.Text.Trim();
            
            if(SD_usr_phone=="" || SD_exp_no=="") //输入规则检查
            {
                label_SendPKG_status.Text = "输入有误，请重新输入!";
                return ;
            }
            if (textBox_SD_usr_name.Text.Trim() != "")
            {
                SD_usr_name = textBox_SD_usr_name.Text.Trim();
            }

            //返回合适的空箱子
            boxDX = "1";
            string BoxID=MyBox.FindBox(boxDX);
            if (BoxID == "") //无合适箱子
            {
                label_SendPKG_status.Text = "该规格箱子已满，请重新选择！";
            }
            else
            {

                //打开箱子
                if(MyBox.OpenBox(BoxID)) //打开成功,成功存包
                {
                    #region
                    //语音提示

                    //产生8位随机提取码
                    Encrypt eBoxEncrypt=new Encrypt();
                    string SD_usr_Code=eBoxEncrypt.GenUserCode();
                    DateTime TimeNow= System.DateTime.Now.ToLocalTime();                                    

                    try
                    {
                        OleCon = new OleDbConnection(strcon);
                        OleCon.Open();
                        //更新存包记录数据库
                        string sql = String.Format("Insert into PKG_RECORD(Ebox_No,User_phone,User_Code,Postman_No,Box_ID,Time_Save,Exp_Num) Values('{0}','{1}','{2}','{3}','{4}',#{5:G}#,'{6}')", Ebox_No, SD_usr_phone, SD_usr_Code, Login_PSTM_phone, BoxID, TimeNow, SD_exp_no);
                        OleCom = new OleDbCommand(sql, OleCon);
                        int PassOk = OleCom.ExecuteNonQuery();
                        Console.WriteLine(PassOk);

                        //更新箱子信息数据库
                        //更新box_manage数据库，设置对应箱子为满
                        sql = "Update BOX_MANAGE Set  BOX_MANAGE.Empty_State=false,BOX_MANAGE.Time_update=#" +TimeNow + "# where BOX_MANAGE.Box_ID='" + BoxID + "'";
                        OleCom = new OleDbCommand(sql, OleCon);
                        int ReturnVal = OleCom.ExecuteNonQuery();
                        Console.WriteLine(ReturnVal);


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        OleCon.Close();
                    }

                    //更新空箱数
                    Box_Num_used += 1;
                    Box_Used_amount += 1;

                    //更新快递员余额数据库                                 
                    ebox_webservice.ebox_serviceSoapClient ebox_webserver = new ebox_webservice.ebox_serviceSoapClient();
                    Login_PSTM_balance=ebox_webserver.Postman_Spend(Login_PSTM_phone,1);
                    toolStripStatusLabel1.Text = "快递员：" + Login_PSTM_phone + ", 欢迎您!  余额：" + Login_PSTM_balance.ToString();

                    //超时计时开始
                    label_SendPKG_status.Text = BoxID+"箱已打开，请存入包裹，关好箱门!";
                    textBox_SD_usr_phone.Text = "";
                    textBox_SD_express_No.Text = "";

                    ShowEboxStatus();
                    #endregion
                }               
                else //打开失败
                {
                    label_SendPKG_status.Text = "打开箱子失败，请重新选择！";
                }
            }
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleCon = new OleDbConnection(strcon);
            OleCon.Open();
            string sql = "Insert into PKG_RECORD(Ebox_No) Values(1000)";
           // string sql = "Insert into PKG_RECORD(Ebox_No,User_phone,User_Code,Postman_No,BoxID,Time_Save,Flag_Taked,Exp_Num) Values(1000)";
            OleCom = new OleDbCommand(sql, OleCon);
            int PassOk = OleCom.ExecuteNonQuery();
            Console.WriteLine(PassOk);
        }
    }
}
