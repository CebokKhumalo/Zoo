using System.Threading.Tasks;
using Zoo.Models.TokenAuth;
using Zoo.Web.Controllers;
using Shouldly;
using Xunit;

namespace Zoo.Web.Tests.Controllers
{
    public class HomeController_Tests: ZooWebTestBase
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