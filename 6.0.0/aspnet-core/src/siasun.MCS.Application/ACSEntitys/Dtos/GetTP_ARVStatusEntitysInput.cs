
using Abp.Runtime.Validation;
using siasun.MCS.Dtos;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    /// <summary>
    /// 获取的传入参数Dto
    /// </summary>
    public class GetTP_ARVStatusEntitysInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

        //// custom codes

        public TP_ARVStatusEntityEditDto TP_ARVStatusEntity { get; set; }

        public int?[] arvIdArr { get; set; }

        //// custom codes end
    }
}
