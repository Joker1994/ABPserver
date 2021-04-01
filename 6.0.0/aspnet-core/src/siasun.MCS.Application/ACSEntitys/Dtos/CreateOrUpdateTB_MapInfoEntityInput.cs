

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTB_MapInfoEntityInput
    {
        [Required]
        public TB_MapInfoEntityEditDto TB_MapInfoEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}