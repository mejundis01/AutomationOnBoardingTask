﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding.Global
{
    internal class Login
    {      
        //create constructor
        public Login()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
              

        #region  Initialize Web Elements 
        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement PassWord { get; set; }

        // Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement loginButton { get; set; }

        #endregion

        internal void LoginSuccessfull()
        {
                       
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "LoginPage");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));
            Driver.wait(500);
            // Sending the username 
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            // Sending the password
            PassWord.SendKeys(ExcelLib.ReadData(2, "Password"));

            // Clicking on the login button
            loginButton.Click();
           
        }
    }
}