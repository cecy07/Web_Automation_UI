using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web_Automation_UI.src.code.page;

namespace Web_Automation_UI.src.code.test
{
    [TestClass]
    public class Task2_Project : Task2_TestBase
    {
        Task2_MainPage mainPage = new Task2_MainPage();
        Task2_projectPage projectPage = new Task2_projectPage();

        [TestMethod]
        public void sending_email()
        {
            //Log in
            string user = "test_page@gmail.com";
            string password = "zxcmnb078";
            mainPage.loginButton.Click();
            mainPage.Login(user, password);

            //Create project
            string name_project = "Test_1";
            projectPage.addProjButton.Click();
            projectPage.newProject(name_project);
            
            Assert.AreEqual(name_project,projectPage.checkName.getText(),"ERROR: Project not created");

            //Modify project
            string modified_project = "Test_modified";
            projectPage.modifyProjButton.Click();
            projectPage.editProjButton.Click();
            projectPage.newProject(modified_project);
            Assert.AreEqual(modified_project, projectPage.checkName.getText(), "ERROR: Project not modified");

            //Delete project
            projectPage.modifyProjButton.Click();
            projectPage.deleteProjButton.Click();
            projectPage.deleteButton.Click();
            Assert.AreNotEqual(modified_project, projectPage.checkName.getText(), "ERROR: Project not deleted");
        }
    }
}