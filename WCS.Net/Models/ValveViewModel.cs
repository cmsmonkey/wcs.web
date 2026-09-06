namespace WCS.Net.Models;

public class ValvePhoto
{
    public required string Src { get; init; }
    public required string Alt { get; init; }
}

public class ValveViewModel
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Kicker { get; init; }
    public required IReadOnlyList<string> IntroParagraphs { get; init; }
    public required IReadOnlyList<ValvePhoto> Photos { get; init; }
}
