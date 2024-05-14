using System;

namespace EFCoreExample
{
    public class Inventory
    {
        public int Id { get; init; }
        public required Item Item { get; init; }
        public required int Qty { get; init; }
        public required Location Location { get; init; }
    }
}