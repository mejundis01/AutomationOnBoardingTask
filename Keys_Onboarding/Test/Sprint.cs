using Keys_Onboarding.Global;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_Onboarding.Test
{
    class Sprint
    {
        [TestFixture]
        [Category("Sprint1")]
        class PO_DashboardFeature : Base
        {

            [Test]
            public void PO_AddNewProperty()
            {


                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add New Property");

                // Create an class and object to call the method
                //PropertyOwner obj = new PropertyOwner();
                //obj.SearchAProperty();

                PropertyOwner obj = new PropertyOwner();
                obj.AddNewProperty();


            }

            [Test]
            public void PO_AddNewTenant()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add a Tenant");

                PropertyOwner obj = new PropertyOwner();
                obj.AddTenant();
            }


            [Test]
            public void PO_ListARental()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add a rental property");

                PropertyOwner obj = new PropertyOwner();
                obj.ListAsRental();

            }

            [Test]
            public void PO_SendRequest()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add a rental property");

                PropertyOwner obj = new PropertyOwner();
                obj.SendRequest();
            }
        }

        [TestFixture]
        [Category("Sprint2")]
        class PO_InspectionsFeature : Base
        {

            [Test]
            public void PO_Inspections()
            {

                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Add a New Inspection Request");

                PropertyOwner obj = new PropertyOwner();
                obj.Inspections();
            }
        }
    }
}

