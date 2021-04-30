using System;
using System.Threading.Tasks;
using FluentAssertions;
using Inspire.Services;
using InspireApi.Controllers;
using Moq;
using NUnit.Framework;

namespace InspireApi.UnitTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class GivenAnInspireController_
    {
        private InspireController _inspireController;
        private Mock<IInspireService> _mockInspireService;

        [SetUp]
        public void Setup()
        {
            _mockInspireService = new Mock<IInspireService>(MockBehavior.Strict);
            _mockInspireService.Setup(x => x.GetInspirationalQuote()).ReturnsAsync("test");
            
            _inspireController = new InspireController(_mockInspireService.Object);
        }

        [Test]
        public void WhenGetIsInvoked_ThenNoExceptionIsThrown()
        {
            Func<Task> act = async () => await _inspireController.Get();
            
            act.Should().NotThrow();
        }

        [Test]
        public async Task WhenGetIsInvoked_ThenInspireServiceGetInspirationalQuoteIsCalled()
        {
            await _inspireController.Get();
            
            _mockInspireService.Verify(x => x.GetInspirationalQuote(), Times.Once);
        }
    }
}