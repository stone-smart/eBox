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
        public Boolean Postman_Verify(string PhoneNo, string Psw)
        {

            return true;
        }

        [WebMethod]
        //管理员登录验证
        public Boolean Manager_Verify(string PhoneNo, string Psw)
        {

            return true;
        }

        [WebMethod]
        //上传存取包记录
        public Boolean Uploadlog(string log)
        {
            return true;
        }
        
    }
}
