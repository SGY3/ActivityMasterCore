using Microsoft.Build.Framework;

namespace ActivityMasterCore.Models
{
    public class ActivityType
    {
        public int Id { get; set; }
        [Required]
        public string ActivityName { get; set; }
    }
}
