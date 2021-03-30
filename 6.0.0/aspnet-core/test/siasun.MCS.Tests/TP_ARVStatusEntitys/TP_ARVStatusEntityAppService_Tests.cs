
using siasun.MCS.ACSEntitys;
using siasun.MCS.ACSEntitys.Dtos;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace siasun.MCS.Tests.TP_ARVStatusEntitys
{
    public class TP_ARVStatusEntityAppService_Tests : MCSTestBase
    {
        private readonly ITP_ARVStatusEntityAppService _tP_ARVStatusEntityAppService;

        public TP_ARVStatusEntityAppService_Tests()
        {
            _tP_ARVStatusEntityAppService = Resolve<ITP_ARVStatusEntityAppService>();
        }

        [Fact]
        public async Task CreateTP_ARVStatusEntity_Test()
        {
            await _tP_ARVStatusEntityAppService.CreateOrUpdate(new CreateOrUpdateTP_ARVStatusEntityInput
            {
                 TP_ARVStatusEntity = new TP_ARVStatusEntityEditDto    
                {
						   

                            c_TimeStamp = DateTime.Now,


                }
            });

            await UsingDbContextAsync(async context =>
            {
                //var dystopiaTP_ARVStatusEntity = await context.TP_ARVStatusEntitys.FirstOrDefaultAsync();
                //dystopiaTP_ARVStatusEntity.ShouldNotBeNull();
            }
            );
        }

        [Fact]
        public async Task GetTP_ARVStatusEntitys_Test()
        {
            // Act
            var output = await _tP_ARVStatusEntityAppService.GetPaged(new GetTP_ARVStatusEntitysInput
            {
                MaxResultCount = 20,
                SkipCount = 0
            });

            // Assert
            output.Items.Count.ShouldBeGreaterThanOrEqualTo(0);
        }

		
							//// custom codes
									
							

							//// custom codes end


    }
}