

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTP_OrderListEntityInput
    {
        [Required]
        public TP_OrderListEntityEditDto TP_OrderListEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}