namespace WindBlogTheme.Common.Constants;

public static class ColorClasses
{
    public static readonly HashSet<string> SupportedColors = [
        "#1e3a8a",
        "#27ae60",
        "#d35400",
        "#8e44ad",
        "#7f8c8d"
    ];

    public static string? GetColorClass(string? hexColor, string prefix = "bg")
    {
        if (string.IsNullOrWhiteSpace(hexColor))
            return null;

        if (!SupportedColors.Contains(hexColor))
            return null;

        return $"{prefix}-{hexColor.TrimStart('#')}";
    }
}
