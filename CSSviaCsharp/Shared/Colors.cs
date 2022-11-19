namespace CSSviaCsharp.Shared.Themes
{
    public struct MaterialTheme
    {
        private string _name;
        public MaterialTheme(string name)
        {
            _name = name;
            ThemeColors = new();
        }
        public readonly List<Color> ThemeColors { get; init; }

        public void AddColor(string color)
        {
            ThemeColors.Add(new Color() { });
        }
    }

}
public record struct Color
{
    public string? Value;
}

