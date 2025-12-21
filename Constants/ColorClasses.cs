namespace WindyBlog.WindBlogTheme.Constants;

public static class ColorClasses
{
    public static readonly HashSet<string> SupportedColors = [
        "#1e3a8a",
        "#000000",
        "#003366",
        "#ff0000"
    ];

    public static string? GetColorClass(string? hexColor)
    {
        if (string.IsNullOrWhiteSpace(hexColor))
            return null;

        if (!SupportedColors.Contains(hexColor))
            return null;

        return $"bg-{hexColor.TrimStart('#')}";
    }
}
