

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTP_OrderLogEntityInput
    {
        [Required]
        public TP_OrderLogEntityEditDto TP_OrderLogEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}