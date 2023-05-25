using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Automation_UI.src.code.factoryBrowser
{
    public class FactoryBrowser
    {

        public static IBrowser Make(String type)
        {
            IBrowser browser;

            switch (type)
            {
                case "chrome":
                    browser = new Chrome();
                    break;
                case "firefox":
                    browser = new Firefox();
                    break;
                default:
                    browser = new Chrome();
                    break;
            }
            return browser;
        }


    }
}
