using Microsoft.Build.Framework;

namespace ActivityMasterCore.Models
{
    public class Activity
    {
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ActivityName { get; set; }
        public string PageName { get; set; }
        public string SpName { get; set; }

    }
}
