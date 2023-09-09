namespace Knev.CV.Models
{
    public class CertificateModel : BaseCardModel
    {
        public string Uri { get; set; } = default!;
        public IEnumerable<string> Skills { get; set; } = new List<string>();
    }
}
