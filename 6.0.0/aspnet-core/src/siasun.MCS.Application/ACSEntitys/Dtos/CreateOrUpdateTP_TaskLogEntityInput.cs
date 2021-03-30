

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTP_TaskLogEntityInput
    {
        [Required]
        public TP_TaskLogEntityEditDto TP_TaskLogEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}