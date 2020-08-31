using System.Collections.Generic;
using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace TraderMikes.Test
{
    [TestClass]
    public class LocationsControllerTest
    {
        private TestServer CreateTestServer()
        {
            var configurationEntries = new Dictionary<string, string>
            {
                ["ConnectionStrings:ClientsDbConnectionString"] = "Server=(local);Database=TraderMikesDb;Trusted_Connection=True;",
            };

            var configurationBuilder = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddInMemoryCollection(configurationEntries);

            var configuration = configurationBuilder.Build();

            var webHostBuilder = new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configuration);

            return new TestServer(webHostBuilder);
        }

        [TestMethod]
        public void GivenATestController_WhenIRequestItemById_ThenTheCallReturns200()
        {
            var testServer = CreateTestServer();
            var client = testServer.CreateClient();

            var response = client.GetAsync("/locations/1").GetAwaiter().GetResult();

            response.IsSuccessStatusCode.Should().BeTrue();
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var responseText = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var responseJson = JToken.Parse(responseText);

            responseJson["name"].Value<string>().Should().Be("Boise");
        }
    }
}
