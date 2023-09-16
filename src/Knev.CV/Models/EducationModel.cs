namespace Knev.CV.Models
{
    public class EducationModel : BaseCardModel
    {
        public string StartOn { get; set; } = default!;
        public string? EndOn { get; set; }
        public string? School { get; set; }
        public string? SchoolIconUri { get; set; }
        public string? Degree { get; set; }

        public IEnumerable<string> Skills { get; set; } = new List<string>();

    }
}
