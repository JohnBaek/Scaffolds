using System.Net;
using System.Net.Http;
using System;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace WebProject.API.Tests
{
    /// <summary>
    /// NetworkControllerTests
    /// </summary>
    public class NetworkControllerTests : IClassFixture<WebApplicationFactory<WebProject.API.Startup>>
    {
        /// <summary>
        /// API Request Client 
        /// </summary>
        /// <value></value>
        public HttpClient httpClient { get; }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="fixture"></param>
        public NetworkControllerTests(WebApplicationFactory<WebProject.API.Startup> fixture)
        {
            httpClient = fixture.CreateClient();
        }

        [Fact]
        public async Task Get_Should_Retrieve_ClientIP()
        {
            HttpResponseMessage response = await httpClient.GetAsync("/api/v1/Network/ClientIP");
            response.StatusCode.Should().Be(HttpStatusCode.OK);            
        }    
    }
}
