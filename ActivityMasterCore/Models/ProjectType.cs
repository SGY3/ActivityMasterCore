using Microsoft.Build.Framework;

namespace ActivityMasterCore.Models
{
    public class ProjectType
    {
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }

    }
}
