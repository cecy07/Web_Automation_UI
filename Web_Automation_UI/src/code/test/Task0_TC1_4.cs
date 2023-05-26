using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using Web_Automation_UI.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Automation_UI.src.code.test
{
    [TestClass]
    public class Task0_TC1_4 : Task0_TestBase
    {   
        Task0_MainPage mainPage = new Task0_MainPage();
        Task0_LoginSection loginSection = new Task0_LoginSection();
        Task0_ProjectPage projectPage = new Task0_ProjectPage();
        Task0_SettingSection settingSection = new Task0_SettingSection();



        [TestMethod]
        public void TC1_to_4()
        {
            string user = "testCecy@gmail.com";
            string password = "password";

            mainPage.loginButton.Click();
            loginSection.emailTxtBox.SetText(user);
            loginSection.pwdTxtBox.SetText(password);
            loginSection.loginButton.Click();

            //TC1_ Create a project with a valid name
            string project_name = "Test";
            projectPage.addNewProjectButton.Click();
            projectPage.projectNameTxtBox.SetText(project_name);
            projectPage.addButton.Click();
            Assert.IsTrue(projectPage.NameDisplayed(project_name),"ERROR: project not created");

            //TC2_ Change icon of project
            projectPage.ClickProjectName(project_name);
            projectPage.subMenuIcon.Click();
            projectPage.ladybugIconButton.Click();
            Assert.IsTrue(projectPage.NameDisplayed(project_name), "ERROR: project not created");

            //TC3_ Edit name of an existing project
            string project_name_change = "Test_modified";
            projectPage.ClickProjectName(project_name);
            projectPage.subMenuIcon.Click();
            projectPage.editButton.Click();
            projectPage.projectNameEditTxtBox.SetText(project_name_change);
            projectPage.saveButton.Click();
            Assert.IsTrue(projectPage.NameDisplayed(project_name_change), "ERROR: project not created");

            //TC4_ Change user name
            string new_user = "Test_user_modified";
            settingSection.settingConfiguration.Click();
            settingSection.nameChange(new_user);
            settingSection.setConfiguration.Click();
            settingSection.nameChange(new_user);
            Assert.IsTrue(settingSection.NameDisplayed(new_user), "ERROR: name of user not changed");
            settingSection.setConfiguration.Click();


        }
    }
}