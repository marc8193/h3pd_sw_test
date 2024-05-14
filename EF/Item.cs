using System;

namespace EFCoreExample
{
    public class Item
    {
        public int Id { get; init; }
        public string Name { get; init; } = String.Empty;
        public string Description { get; init; } = String.Empty;
        public double? Price { get; init; } 

    }
}