using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBox_Client
{
    
    class Box //电子柜类
    {
        public int box_num;

        public void openBox(string phone) //打开柜子  根据手机号码 
        { 
           box_num=1;
        }

        public void openBox()//重载函数 
        {
            box_num = 2;
        }

    }
}
