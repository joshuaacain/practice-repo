using System.Threading.Tasks;
using NutNull.DemoProject.Models.TokenAuth;
using NutNull.DemoProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace NutNull.DemoProject.Web.Tests.Controllers
{
    public class HomeController_Tests: DemoProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}