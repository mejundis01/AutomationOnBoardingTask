using System;
using TechTalk.SpecFlow;

namespace Keys_Onboarding
{
    [Binding]
    public class PropertyOwnerSteps : Global.Base
    {
        [Given(@"User have logged into the application")]
        public void GivenUserHaveLoggedIntoTheApplication()
        {
            Inititalize();
        }
        
        [When(@"User have added a new property")]
        public void WhenUserHaveAddedANewProperty()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Add New Property");

            PropertyOwner obj = new PropertyOwner();
            obj.AddNewProperty();
        
        }

        [When(@"User have listed a new tenant")]
        public void WhenUserHaveListedANewTenant()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Add a Tenant");

            PropertyOwner obj = new PropertyOwner();
            obj.AddTenant();
        }

        [When(@"User have listed a new rental property")]
        public void WhenUserHaveListedANewRentalProperty()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Add a rental property");

            PropertyOwner obj = new PropertyOwner();
            obj.ListAsRental();

        }

        [When(@"User have sent a new request")]
        public void WhenUserHaveSentANewRequest()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Send a request");

            PropertyOwner obj = new PropertyOwner();
            obj.SendRequest();
        }

        [Then(@"The browser will be closed")]
        public void ThenTheBrowserWillBeClosed()
        {
            // Creates a toggle for the given test, adds all log events under it
            test = extent.StartTest("Add a Tenant");

            TearDown();
        } 

        [When(@"User have sent a new inspection request")]
        public void WhenUserHaveSentANewInspectionRequest()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Send a new inspection request");

            PropertyOwner obj = new PropertyOwner();
            obj.Inspections();
        }

    }
}
