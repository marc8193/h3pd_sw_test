using System;

namespace EFCoreExample
{
    public class Item
    {
        public int Id { get; init; }
        public required string Name { get; init; } = String.Empty;
        public required string Description { get; init; } = String.Empty;
        public double? Price { get; init; } 
        public string? Barcode { get; set; }
    }
}