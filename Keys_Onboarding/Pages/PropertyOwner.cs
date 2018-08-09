using AutoItX3Lib;
using Keys_Onboarding.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static Keys_Onboarding.Global.CommonMethods;


namespace Keys_Onboarding
{
    public class PropertyOwner
    {
        public PropertyOwner()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        #region WebElements Definition
        //Define Owners tab
        [FindsBy(How =How.XPath, Using = "//div[@class='container']/div[2]/div[1]")]
        private IWebElement Ownertab { get; set; }

        //Define Properties page
        [FindsBy(How = How.XPath, Using = "//a[@href='/PropertyOwners']")]
        private IWebElement PropertiesPage { get; set; }

        //Define search bar        
        [FindsBy(How = How.Id, Using = "SearchBox")]
        private IWebElement SearchBar { get; set; }

        //Define search button
        [FindsBy(How = How.XPath, Using = "//i[@id='icon-submitt']")]
        private IWebElement SearchButton { get; set; }

        //Define skip button on pop up 
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement Skip { get; set; }

        #endregion

        public void Common_methods()
        {
            Driver.wait(10);

            //Click on Skip on the pop up window
            Skip.Click();

            //Click on the Owners tab
            Thread.Sleep(1000);
            Ownertab.Click();

            //Select properties page
            PropertiesPage.Click();
        }

        internal void SearchAProperty()
        {
            try
            {
                //Calling the common methods
                Common_methods();
                Thread.Sleep(500);

                //Driver.wait(5);

                //Enter the value in the search bar
                SearchBar.SendKeys("TestingProperty");
                Thread.Sleep(500);
                //Global.Driver.wait(5);

                //Click on the search button
                SearchButton.Click();
                Thread.Sleep(1000);
                //Driver.wait(5);

                string ExpectedValue = "TestingProperty";
                string ActualValue = Global.Driver.driver.FindElement(By.XPath("//div[@class='six wide column']/a/h3")).Text;

                //Assert.AreEqual(ExpectedValue, ActualValue);
                if (ExpectedValue == ActualValue)
                                    
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Search successfull");
                
                else
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull");

            }

            catch(Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull",e.Message);
            }
         }

        //Define Add New Property button
        [FindsBy(How = How.XPath, Using = "//div[@id='main-content']/div/div/div/div[2]/div/div[2]/a[2]")]
        private IWebElement AddProperty { get; set; }

        //Define Property Name bar
        [FindsBy(How = How.Name, Using = "propertyName")]
        private IWebElement PropertyName { get; set; }

        //Define Property Type
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div")]
        private IWebElement PropertyType { get; set; }

        //Define Short Term Rentak on Property Type
        [FindsBy(How = How.XPath, Using = "//div[@class='menu transition visible']/div[4]")]
        private IWebElement PropertyTypeChoice { get; set; }

        //Define Street Number bar
        [FindsBy(How = How.XPath, Using = "//div[@class='six wide field']/div/input")]
        private IWebElement StreetNumber { get; set; }

        //Define Street Name bar
        [FindsBy(How = How.XPath, Using = "//div[@class='ten wide field']/div/input")]
        private IWebElement StreetName { get; set; }

        //Define City Name bar
        [FindsBy(How = How.XPath, Using = "//div[@class='three fields']/div[2]/div/input")]
        private IWebElement CityName { get; set; }

        //Define PostCode bar
        [FindsBy(How = How.XPath, Using = "//div[@class='three fields']/div[3]/div/input")]
        private IWebElement PostCode { get; set; }

        //Define Region bar
        [FindsBy(How = How.XPath, Using = "//input[@id='region']")]
        private IWebElement Region { get; set; }

        //Define Description text bar
        [FindsBy(How = How.ClassName, Using = "add-prop-desc")]
        private IWebElement Description { get; set; }

        //Define TargetRent bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Rent Amount']")]
        private IWebElement TargetRent { get; set; }

        //Define Bedrooms bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of Bedrooms']")]
        private IWebElement Bedrooms { get; set; }

        //Define Bathrooms bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of Bathrooms']")]
        private IWebElement Bathrooms { get; set; }

        //Define Carparks bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of car parks']")]
        private IWebElement Carparks { get; set; }

        //Define Year Built bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Year Built']")]
        private IWebElement YearBuilt { get; set; }

        //Define Year Built bar
        [FindsBy(How = How.Id, Using = "file-upload")]
        private IWebElement FileUpload { get; set; }

        //Define Next button
        [FindsBy(How = How.Name, Using = "next")]
        private IWebElement Next { get; set; }

        //Define Purchase Price bar
        [FindsBy(How = How.Name, Using = "purchasePrice")]
        private IWebElement PurchasePrice { get; set; }

        //Define Mortgage bar
        [FindsBy(How = How.Name, Using = "mortgagePrice")]
        private IWebElement Mortgage { get; set; }

        //Define Home Value bar
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='financeSection']/div/div[3]/div/input")]
        private IWebElement HomeValue { get; set; }

        //Define Next Finance button
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide column text-center']/button[3]")]
        private IWebElement NextFinance { get; set; }

        //Define Email bar
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        //Define FirstName bar
        [FindsBy(How = How.Id, Using = "fname")]
        private IWebElement FirstName { get; set; }

        //Define LastName bar
        [FindsBy(How = How.Id, Using = "lname")]
        private IWebElement LastName { get; set; }

        //Define start date bar
        [FindsBy(How = How.Id, Using = "sdate")]
        private IWebElement StartDate { get; set; }

        //Define end date bar
        [FindsBy(How = How.Id, Using = "edate")]
        private IWebElement EndDate { get; set; }

        //Define rent amount bar
        [FindsBy(How = How.Id, Using = "ramount")]
        private IWebElement RentAmount { get; set; }

        //Define payment start date bar
        [FindsBy(How = How.Id, Using = "psdate")]
        private IWebElement PSDate { get; set; }

        //Define payment due date drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[10]/div")]
        private IWebElement PaymentOpt { get; set; }

        //Define payment due date drop down
        [FindsBy(How = How.XPath, Using = "//div[@class='menu transition visible']/div[2]")]
        private IWebElement PaymentOptTwo { get; set; }

        //Define end date bar
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide text-center']/button[2]")]
        private IWebElement SaveProperty { get; set; }

        internal void AddNewProperty()
        {

            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Config.Keys_Resource.ExcelPath, "Register");
            Thread.Sleep(1000);

            //calling the common methods
            Common_methods();
            Thread.Sleep(500);

            //Click on Add New Property button
            AddProperty.Click();

            //Calling Property details method
            PropertyDetails();

            //Calling Finance details method
            FinanceDetails();

            //Calling Tenant details method
            TenantDetails();         
                        

        }

        public void PropertyDetails()
        {
            //Enter the Property Name
            PropertyName.SendKeys(ExcelLib.ReadData(2, "PropertyName"));
            Thread.Sleep(500);

            //Click on Property Type drop down menu
            PropertyType.Click();

            //Clicking Short-Term Rental on the Property Type drop down menu
            PropertyTypeChoice.Click();
            Thread.Sleep(500);

            //Enter Street Number
            StreetNumber.SendKeys(ExcelLib.ReadData(2, "Number"));
            Driver.wait(1000);

            //Enter Street Name
            StreetName.SendKeys(ExcelLib.ReadData(2, "Street"));
            Driver.wait(1000); 

            //Enter City Name
            CityName.SendKeys(ExcelLib.ReadData(2, "City"));
            Driver.wait(1000);

            //Enter PostCode
            PostCode.SendKeys(ExcelLib.ReadData(2, "PostCode"));
            Driver.wait(1000);

            //Enter Region Name
            Region.SendKeys(ExcelLib.ReadData(2, "Region"));
            Driver.wait(1000);

            //Enter Description
            Description.SendKeys(ExcelLib.ReadData(2, "Description"));
            Driver.wait(1000);

            //Enter TargetRent
            TargetRent.SendKeys(ExcelLib.ReadData(2, "TargetRent"));
            Driver.wait(1000);

            //Enter Bedroms
            Bedrooms.SendKeys(ExcelLib.ReadData(2, "Bedrooms"));
            Driver.wait(2000);

            //Enter Bathrooms
            Bathrooms.SendKeys(ExcelLib.ReadData(2, "Bathrooms"));
            Driver.wait(2000);

            //Enter Carparks
            Carparks.SendKeys(ExcelLib.ReadData(2, "Carparks"));
            Driver.wait(3000);

            //Enter Year Built
            YearBuilt.SendKeys(ExcelLib.ReadData(2, "YearBuilt"));
            Driver.wait(2000);

            //Upload a file thru AutoIT
            Driver.wait(1000);
            AutoItX3 autoIT = new AutoItX3();
            FileUpload.Click();
            autoIT.WinActivate("Open");
            Thread.Sleep(1000);
            autoIT.Send(@"C:\Users\VictorFelix\source\repos\automationOnboardingSample-master\Keys_Onboarding\TestReports\Screenshots\home.jpg");
            Thread.Sleep(1000);
            autoIT.Send("{Enter}");
            Thread.Sleep(1000);

            //Clicking on Next button
            Next.Click();
            Driver.wait(2000);

        }

        public void FinanceDetails()
        {
            
            //Enter Purchase Prise value
            PurchasePrice.SendKeys(ExcelLib.ReadData(2, "PurchasePrice"));
            Driver.wait(1000);

            //Enter Mortgage value
            Mortgage.SendKeys(ExcelLib.ReadData(2, "Mortgage"));
            Driver.wait(1000);

            //Enter Home Value
            HomeValue.SendKeys(ExcelLib.ReadData(2, "HomeValue"));
            Driver.wait(1000);

            //Clicking on next button
            NextFinance.Click();
            Thread.Sleep(500);
        }

        public void TenantDetails()
        {
            //Enter email
            Email.SendKeys(ExcelLib.ReadData(2, "TenantEmail"));
            Driver.wait(1000);

            //Enter FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));
            Driver.wait(1000);

            //Enter LastName
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));
            Driver.wait(1000);

            //Clear Start date bar
            StartDate.Clear();
            Driver.wait(1000);

            //Enter StartDate
            StartDate.SendKeys("12/08/2018");
            Driver.wait(1000);

            //Clear Start date bar
            EndDate.Clear();
            Driver.wait(1000);

            //Enter EndDate
            EndDate.SendKeys("21/08/2019");
            Driver.wait(1000);

            //Enter Rent amount
            RentAmount.SendKeys(ExcelLib.ReadData(2, "RentAmount"));
            Driver.wait(1000);

            //Clear Payment Start date bar
            PSDate.Clear();
            Driver.wait(1000);

            //Enter payment start date
            PSDate.SendKeys("15/08/2018");
            Driver.wait(1000);

            //Clicking on Payment option drop down
            PaymentOpt.Click();
            Driver.wait(2000);

            //Clicking on Payment option 2 in drop down 
            PaymentOptTwo.Click();
            Driver.wait(2000);

            //Clinking on Save add button
            SaveProperty.Click();
            Driver.wait(2000);
            //Click(By.Id("saveProperty"));
        }

            
        //Define Add Tenant button
        [FindsBy(How = How.XPath, Using = "//div[@class='extra']/div/a[1]")]
        private IWebElement AddaTenant { get; set; }

        //Define Email bar
        [FindsBy(How = How.Name, Using = "Email")]
        private IWebElement TenantEmail { get; set; }

        //Define Tenant FirstName bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First Name']")]
        private IWebElement TenantFName { get; set; }

        //Define Tenant LastName bar
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[4]/div[2]/div[1]/input")]
        private IWebElement TenantLName { get; set; }

        //Define Tenant Start Date bar
        [FindsBy(How = How.Name, Using = "StartDate")]
        private IWebElement TenantSDate { get; set; }

        //Define Tenant End date bar
        [FindsBy(How = How.Name, Using = "EndDate")]
        private IWebElement TenantEDate { get; set; }

        //Define Tenant End date bar
        [FindsBy(How = How.Name, Using = "RentAmount")]
        private IWebElement TenantRAmount { get; set; }

        //Define Tenant payment start date bar
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Payment Start Date']")]
        private IWebElement TenantPSDate { get; set; }

        //Define TenantNext button
        [FindsBy(How = How.XPath, Using = "//input[@value='Next']")]
        private IWebElement TenantNext { get; set; }

        //Define Tenant second Next button
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='LiabilityDetail']/div[2]/div/button[2]")]
        private IWebElement TenantSNext { get; set; }

        //Define Tenant submit button
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='SummaryDetail']/div[10]/div/button[2]")]
        private IWebElement TenantSubmit { get; set; }

        //Define Home Away text
        [FindsBy(How = How.LinkText, Using = "HomeAwayFromHome")]
        private IWebElement HomeAway { get; set; }

        //Define Payment due dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[7]/div[2]/div[1]/div/i")]
        private IWebElement PaymentOption { get; set; }

        //Define Payment due option 2
        [FindsBy(How = How.XPath, Using = "//div[@class='menu transition visible']/div[2]")]
        private IWebElement PaymentOptionTwo { get; set; }

        //Define Drop down button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui one wide column']/div[1]")]
        private IWebElement DropDown { get; set; }

        //Define Manage Tenant button
        [FindsBy(How = How.XPath, Using = "//a[@class='default-item-color']")]
        private IWebElement ManageTenant { get; set; }

        internal void AddTenant()
        {
            //Populate excel file
            ExcelLib.PopulateInCollection(Config.Keys_Resource.ExcelPath, "Tenant");
            Thread.Sleep(1000);

            //calling the common methods
            Common_methods();
            Thread.Sleep(500);

            TenantRentDetails();
            
        }

        public void TenantRentDetails()
        {
            
                //Clicking on save button
                AddaTenant.Click();
                Thread.Sleep(500);

                //Enter Tenant email
                TenantEmail.SendKeys(ExcelLib.ReadData(2, "TenantEmail"));
                Driver.wait(1000);

                //Enter tenant first name
                TenantFName.SendKeys("Rosalinda");
                Driver.wait(3000);

                //Enter tenant last name
                /*if (TenantLName.Enabled)
                {
                      TenantLName.SendKeys("Marimar");
                    Driver.wait(3000);
                }
                else
                {
                    Console.WriteLine("No Element found");
                }*/


                //Enter Tenant rent start date
                TenantSDate.Clear();
                TenantSDate.SendKeys("12/08/2018");
                Driver.wait(2000);

                //Enter Tenant rent end date
                TenantEDate.Clear();
                TenantEDate.SendKeys("12/08/2019");
                Driver.wait(2000);

                //Enter tenant payment start date
                TenantRAmount.SendKeys(ExcelLib.ReadData(2, "RentAmount"));
                Driver.wait(2000);

                //Enter tenant payment date start 
                TenantPSDate.Clear();
                TenantPSDate.SendKeys("15/08/2018");
                Driver.wait(2000);

                //Clicking on payment due dropdown menu
                PaymentOption.Click();
                Thread.Sleep(500);

                //Clicking on payment option 2
                PaymentOptionTwo.Click();
                Thread.Sleep(500);
            
                //Clicking on Tenant Next button
                if (TenantNext.Enabled)
                {
                    TenantNext.Click();
                    Driver.wait(2000);
                }
                Driver.wait(2000);
                //Clicking on Tenant second Next button
                if (TenantSNext.Displayed)
                {
                    TenantSNext.Click();

                }

                Driver.wait(3000);
                //Clicking on Tenant submit button
                if (TenantSubmit.Displayed)
                {
                    TenantSubmit.Click();
                    Driver.wait(2000);
                }

                Driver.wait(5000);

            //Clicking on Dropdown
            if (DropDown.Displayed)
            {
                DropDown.Click();
                Driver.wait(2000);
            }
                //Clicking on Dropdown
                ManageTenant.Click();
                Driver.wait(2000);

        }

        //Define List as rental button
        [FindsBy(How = How.XPath, Using = "//div[@class='extra']/div/a[2]")]
        private IWebElement ListaRental { get; set; }

        //Define Title bar
        [FindsBy(How = How.XPath, Using = "//div[@class='two fields']/div/input[1]")]
        private IWebElement Title { get; set; }

        //Define Moving Cost bar
        [FindsBy(How = How.XPath, Using = "//div[@class='two fields']/div/input[2]")]
        private IWebElement MovingCost { get; set; }

        //Define List Rental Description bar
        [FindsBy(How = How.XPath, Using = "//textarea[@rows='5']")]
        private IWebElement ListDescription { get; set; }

        //Define List TargetRent bar
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[4]/div[1]/input")]
        private IWebElement ListTargetRent { get; set; }

        //Define Available date bar
        [FindsBy(How = How.Name, Using = "AvailableDate")]
        private IWebElement AvailableDate { get; set; }

        //Define Occupants Count bar
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[6]/div[1]/input")]
        private IWebElement OccupantCount { get; set; }

        //Define Available date bar
        [FindsBy(How = How.Id, Using = "file-upload")]
        private IWebElement Uploadingfile { get; set; }

        //Define Save button
        [FindsBy(How = How.XPath, Using = "//div[@class='sixtween wide center aligned column']/button[1]")]
        private IWebElement ListSave { get; set; }

        //Define Search Box bar
        [FindsBy(How = How.Id, Using = "SearchBox")]
        private IWebElement SearchBox { get; set; }

        //Define Search button
        [FindsBy(How = How.Id, Using = "icon-submitt")]
        private IWebElement SearchBtn { get; set; }

        internal void ListAsRental()
        {

            //Populate excel file
            ExcelLib.PopulateInCollection(Config.Keys_Resource.ExcelPath, "ListRental");
            Thread.Sleep(1000);

            //calling the common methods
            Common_methods();
            Thread.Sleep(500);
                       
            //Clicking on save button
            ListaRental.Click();
            Driver.wait(2000);

            //Enter Title
            Title.SendKeys(ExcelLib.ReadData(2, "Title"));
            Driver.wait(2000);

            //Enter moving cost
            MovingCost.SendKeys(ExcelLib.ReadData(2, "MovingCost"));
            Driver.wait(2000);

            //Enter List Description
            ListDescription.SendKeys(ExcelLib.ReadData(2, "Description"));
            Driver.wait(2000);
            
            //Enter List target rent
            ListTargetRent.SendKeys(ExcelLib.ReadData(2, "TargetRent"));
            Driver.wait(2000);

            //Enter Available date
            AvailableDate.Clear();
            Driver.wait(500);
            AvailableDate.SendKeys("16/08/2018");
            Driver.wait(2000);

            //Enter Occupant Count
            OccupantCount.SendKeys(ExcelLib.ReadData(2, "Occupants"));
            Driver.wait(2000);

            //Upload a file thru AutoIT
            Driver.wait(1000);
            AutoItX3 autoIT = new AutoItX3();
            Uploadingfile.Click();
            autoIT.WinActivate("Open");
            Thread.Sleep(1000);
            autoIT.Send(@"C:\Users\VictorFelix\source\repos\automationOnboardingSample-master\Keys_Onboarding\TestReports\Screenshots\home.jpg");
            Thread.Sleep(1000);
            autoIT.Send("{Enter}");
            Thread.Sleep(1000);

            //Clicking on Save 
            ListSave.Click();
            Driver.wait(2000);

            //Search for added list property
            SearchBox.SendKeys(ExcelLib.ReadData(2, "Title"));
            Driver.wait(2000);

           //Clicking on Search icon
            SearchBtn.Click();
            Driver.wait(2000);
                      
        }

        //Define Send Request button
        [FindsBy(How = How.XPath, Using = "//div[@class='extra']/div/a[3]")]
        private IWebElement SendaRequest { get; set; }

        //Define Send Request button
        [FindsBy(How = How.XPath, Using = "//textarea[@rows='10']")]
        private IWebElement RequestDesc { get; set; }

        internal void SendRequest()
        {

            //Populate excel file
            ExcelLib.PopulateInCollection(Config.Keys_Resource.ExcelPath, "ListRental");
            Thread.Sleep(1000);

            //calling the common methods
            Common_methods();
            Thread.Sleep(500);

            //Clicking on save button
            SendaRequest.Click();
            Thread.Sleep(1000);

            //Enter Request Description
            RequestDesc.SendKeys(ExcelLib.ReadData(2, "Description"));
            Driver.wait(500);
        }
    }
}