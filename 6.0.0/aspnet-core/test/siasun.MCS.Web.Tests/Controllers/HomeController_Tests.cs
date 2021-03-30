using System.Threading.Tasks;
using siasun.MCS.Models.TokenAuth;
using siasun.MCS.Web.Controllers;
using Shouldly;
using Xunit;

namespace siasun.MCS.Web.Tests.Controllers
{
    public class HomeController_Tests: MCSWebTestBase
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