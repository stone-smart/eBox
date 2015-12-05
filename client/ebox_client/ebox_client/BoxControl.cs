using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ebox_client
{
    //电子柜控制类
    //1.打开电子柜 2.查询空箱子
    class BoxControl
    {
        //类型，变量声明
        enum BOXSIZE{normal=0,small=1,big=2};

        //数据库连接
        public string strcon = "";
        OleDbConnection OleCon = null;
        OleDbCommand OleCom = null;

        struct BOX_ADDR
        {
            public string Control_BD_Addr;
            public string Box_No;
        };

        //构造函数
        public BoxControl(string constr)
        {
            strcon = constr;
        }

        //查询并返回空箱子编号
        public String FindBox(string size)
        {
            string BoxID="";
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from BOX_MANAGE where Box_Size='" + size +"' AND Empty_State=true AND Box_Valid=true"  ;
                OleCom = new OleDbCommand(sql, OleCon);
                OleDbDataReader OleReader = OleCom.ExecuteReader();               
                while (OleReader.Read()) //有记录为True
                {
                    BoxID = OleReader[0].ToString();
                }

                OleReader.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {              
                OleCon.Close();
            }
            
            return BoxID;
        }

        //打开指定编号箱子
        //查找 锁控地址 RS485接口发送命令 打开箱子
        public Boolean OpenBox(string BoxID)
        {
            BOX_ADDR Box_control_addr;
            //查询锁控地址
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from BOX_MANAGE where Box_ID='" + BoxID + "'";
                OleCom = new OleDbCommand(sql, OleCon);
                OleDbDataReader OleReader = OleCom.ExecuteReader();
                while (OleReader.Read()) //有记录为True
                {
                    Box_control_addr.Control_BD_Addr = OleReader[1].ToString();
                    Box_control_addr.Box_No = OleReader[2].ToString();
                }

                OleReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                OleCon.Close();
            }

            //RS485SendCmd_OpenBox(Box_Control_addr);
            return true;
        }


    }
}
