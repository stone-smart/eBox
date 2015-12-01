using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ebox_client
{
    class BoxControl
    {
        //类型，变量声明
        enum BOXSIZE{normal=0,small=1,big=2};

        //数据库连接
        public string strcon = "";
        OleDbConnection OleCon = null;
        OleDbCommand OleCom = null;
         

        //构造函数
        public BoxControl(string constr)
        {
            strcon = constr;
        }

        //查询并返回空箱子编号
        public String FindBox(string size)
        {
            string BoxID="A0";
            try
            {
                OleCon = new OleDbConnection(strcon);
                OleCon.Open();
                string sql = "Select * from BOX_MANAGE where Box_Size='" + size +"' AND Empty_State='0' AND Box_Valid='1'"  ;
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
            return true;
        }


    }
}
