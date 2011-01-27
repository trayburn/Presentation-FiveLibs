using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc.Controllers;
using Rhino.Mocks;
using Mvc.Services;

namespace MvcTest
{
    [TestClass]
    public class HomeControllerTests
    {
        private HomeController cntrl;
        private IMessageService svc;

        [ClassInitialize]
        public void Setup()
        {
            svc = MockRepository.GenerateMock<IMessageService>();
            cntrl = new HomeController(svc);
        }

        [TestMethod]
        public void Can_Display_Inventory()
        {
            cntrl.GetInventory();

        }
    }
}
