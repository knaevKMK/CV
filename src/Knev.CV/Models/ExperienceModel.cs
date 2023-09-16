namespace Knev.CV.Models
{
    public class ExperienceModel : BaseCardModel
    {
        public string LogoUri { get; set; } = string.Empty;
        public string StartOn { get; set; } = default!;
        public string? EndOn { get; set; }
        public string? OwnerTitle { get; set; }

        public IEnumerable<string> Projects { get; set; } = new List<string>();
        public IEnumerable<string> Skills { get; set; } = new List<string>();
    }
}
