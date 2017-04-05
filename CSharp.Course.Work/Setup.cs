using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [SetUpFixture]
    public class Setup
    {
        public static List<TestContext.ResultAdapter> Results { get; set; } = new List<TestContext.ResultAdapter>();

        private readonly string Username = "<Your name here>";
        private readonly string MimeType = "application/json";
        [OneTimeSetUp]
        public void SetUp()
        {
        }

        [OneTimeTearDown]
        public async Task TearDown()
        {
            var passed = Results.Count(r => r.Outcome.Status == TestStatus.Passed);
            var failed = Results.Count(r => r.Outcome.Status == TestStatus.Failed);
            var skipped = Results.Count(r => r.Outcome.Status == TestStatus.Skipped);
            Console.WriteLine($"Passed: {passed}, Failed: {failed}, Skipped: {skipped}");


            var httpClient = new HttpClient() { BaseAddress = new Uri("") };
            httpClient.DefaultRequestHeaders.Add("Accept", MimeType);
            var content = new StringContent(JsonConvert.SerializeObject(new
            {
                Username = Username,
                Passed = passed,
                Failed = failed,
                Skipped = skipped
            }), System.Text.Encoding.UTF8, MimeType);
            var response = await httpClient.PostAsync("api/leaderboard/", content);
            if (!response.IsSuccessStatusCode)
            {
                Assert.Fail($"Couldn't connect with server: {response.StatusCode}, Reason: {response.ReasonPhrase}");
            }
        }
    }
}
