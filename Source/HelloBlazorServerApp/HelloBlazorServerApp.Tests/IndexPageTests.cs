using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Diagnostics.CodeAnalysis;

namespace HelloBlazorServerApp.Tests
{

    [ExcludeFromCodeCoverage]
    [Parallelizable(ParallelScope.Children)]
    public class IndexPageTests : PageTest
    {

        const string _uiLandingPage = "https://localhost:7261";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            await using var browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                Devtools = true,
                SlowMo = 5000,
            });

            IPage _page = await browser.NewPageAsync();

            await _page.GotoAsync(_uiLandingPage);

            var fileName = $"UI_LandingPage_1.PNG";
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = fileName });

            await _page.GetByRole(AriaRole.Link, new() { NameString = "Fetch data" }).ClickAsync();

            await _page.GetByRole(AriaRole.Heading, new() { NameString = "Weather forecast" }).ClickAsync();

            fileName = $"UI_FetchDataPage.PNG";
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = fileName });

            Assert.Pass();
        }
    }
}