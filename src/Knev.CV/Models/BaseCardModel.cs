namespace Knev.CV.Models
{
    public abstract class BaseCardModel
    {
        public string Key { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
