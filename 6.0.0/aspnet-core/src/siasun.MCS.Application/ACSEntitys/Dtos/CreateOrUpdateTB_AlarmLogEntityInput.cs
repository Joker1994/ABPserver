

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTB_AlarmLogEntityInput
    {
        [Required]
        public TB_AlarmLogEntityEditDto TB_AlarmLogEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}