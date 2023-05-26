using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Web_Automation_UI.src.code.control;

namespace Web_Automation_UI.src.code.page
{
    internal class Task2_projectPage
    {

        public Button addProjButton = new Button(By.CssSelector("button[aria-label=\"Add project\"]"));
        public TextBox nameProject = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button createProjButton = new Button(By.CssSelector("button[type=\"submit\"]"));
        public Button modifyProjButton = new Button(By.CssSelector("button[aria-label=\"More project actions\"]:first-child"));
        public Button editProjButton = new Button(By.XPath("//div[contains(text(), 'Edit project')]"));
        public Button deleteProjButton = new Button(By.XPath("//div[contains(text(), 'Delete project')]"));
        public Button deleteButton = new Button(By.XPath("//button[@type=\"submit\"]"));
        public Label checkName = new Label(By.XPath("(//span[@class=\"FnFY2YlPR10DcnOkjvMMmA==\"])[last()]"));

        
        public void newProject(String name)
        {
            nameProject.SetText(name);
            createProjButton.Click();
        }
        public Boolean ProjectNameIsDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//*[@id='"+nameValue+"']/li[3]/div/div/a"));
            return nameProject.IsControlDisplayed();
        }
    }
}
