

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTB_AlarmInfoEntityInput
    {
        [Required]
        public TB_AlarmInfoEntityEditDto TB_AlarmInfoEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}