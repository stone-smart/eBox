using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace eBox_webService
{
    /// <summary>
    /// ebox_service 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://eboxServic.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class ebox_service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        //加法
        public int add(int a, int b)
        {
            return (a + b);
        }

        [WebMethod]
        //快递员登录信息验证
        //返回参数：-100，验证失败；0+整数，余额；                
        public int Verify_Postman(string PhoneNo, string Psw)
        {

            return 20;
        }

        [WebMethod]
        //管理员登录验证
        public Boolean Verify_Manager(string PhoneNo, string Psw)
        {

            return true;
        }

        [WebMethod]
        //上传存取包记录
        public Boolean UploadPkglogItem(string log)
        {
            return true;
        }

        [WebMethod]
        //快递员注册
        public Boolean Register_Postman(string PhoneNo, string Psw)
        {
            return true;
        }

        [WebMethod]
        //快递员存包消费额
        //返回值，余额
        public int Postman_Spend(string PhoneNo, int cost)
        {
            return 18;
        }     
        
    }
}
