using System.ComponentModel.DataAnnotations;

namespace Arahk.Evenness.WebApi.ViewModels
{
    public class CreateProjectViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}