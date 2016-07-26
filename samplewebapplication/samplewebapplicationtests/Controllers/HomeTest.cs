using samplewebapplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace samplewebapplicationtests.Controllers
{
    public class HomeTest
    {
        [Fact]
        public void AboutSetsMessage()
        {
            HomeController homeController = new HomeController();
            var aboutResult =  homeController.About() as ViewResult;
            Assert.Equal("", aboutResult.ViewName);
        }

        [Fact]
        public void ContactSetsMessage()
        {
            HomeController homeController = new HomeController();
            var aboutResult = homeController.Contact() as ViewResult;
            Assert.Equal("", aboutResult.ViewName);
        }
    }
}
