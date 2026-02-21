namespace lesson9_10
{
    class NumbersGroup
    {
        public string Group { get; init; } = string.Empty;

        public IEnumerable<int> Numbers { get; init; } = Enumerable.Empty<int>();
    }
}
