using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Inspire.Services.UnitTests
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public class GivenAnInspireService_
    {
        private IInspireService _inspireService;

        [SetUp]
        public void Setup()
        {
            _inspireService = new InspireService();
        }

        [Test]
        public void WhenGetInspirationalQuoteIsInvoked_ThenNoExceptionIsThrown()
        {
            Func<Task> act = async () => await _inspireService.GetInspirationalQuote();
            
            act.Should().NotThrow();
        }

        [Test]
        public async Task WhenGetInspirationalQuoteIsInvoked_ThenAStringTypeIsReturned()
        {
            var result = await _inspireService.GetInspirationalQuote();

            result.Should().BeOfType<string>();
        }

        [Test]
        public async Task WhenGetInspirationalQuoteIsInvoked_ThenAStringOfTheExpectedValueIsReturned()
        {
            var result = await _inspireService.GetInspirationalQuote();

            result.Should().Be("You are awesome!");
        }
    }
}