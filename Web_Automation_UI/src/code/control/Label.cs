using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Web_Automation_UI.src.code.control
{
    public class Label : ControlSelenium
    {
        public Label(By locator) : base(locator)
        {
        }
        public String getText()
        {
            FindControl();
            return control.GetAttribute("textContent");
        }
    }
}