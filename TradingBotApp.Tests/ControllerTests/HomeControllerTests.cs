﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Moq;
using TradingBotApp.DAL.Repositories.Interfaces;
using TradingBotApp.Models;
using MarketProcessor.MarketConditionQualifiers.Implementation;
using TradingBotApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TradingBotApp.Tests.ControllerTests
{
    [TestFixture]
    internal class HomeControllerTests
    {
        [Test]
        public void Index_NoInputs_ExpectedResultReturned()
        {
            // Arrange
            const int TOOL_ID = 1;
            const string TOOL_NAME = "toolId1";
            const bool TOOL_ENABLED = true;
            const int CONDITION_QUALIFIER_ID = 1;

            Mock<ITradingBotAppRepository> mock = new Mock<ITradingBotAppRepository>();
            mock.Setup(i => i.MarketTools).Returns((new MarketTool[]
            {
                new MarketTool { ID = TOOL_ID, Name = TOOL_NAME, Enabled = TOOL_ENABLED, 
                    MarketConditionQualifierID = CONDITION_QUALIFIER_ID, MarketConditionQualifier = new RamvQualifier() }
            }).AsQueryable());
        
            HomeController controller = new HomeController(mock.Object);

            // Act
            var result = ((ViewResult)controller.Index()).ViewData.Model as IEnumerable<MarketTool>;
            Assert.IsNotNull(result);

            var resArray = result.ToArray();
            Assert.AreEqual(TOOL_ID, resArray[0].ID);
            Assert.AreEqual(TOOL_NAME, resArray[0].Name);
            Assert.AreEqual(TOOL_ENABLED, resArray[0].Enabled);
            Assert.AreEqual(CONDITION_QUALIFIER_ID, resArray[0].MarketConditionQualifierID);
        }
    }
}
