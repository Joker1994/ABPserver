

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siasun.MCS.ACSEntitys;

namespace siasun.MCS.ACSEntitys.Dtos
{
    public class CreateOrUpdateTP_TaskListEntityInput
    {
        [Required]
        public TP_TaskListEntityEditDto TP_TaskListEntity { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}