using System;

namespace EFCoreExample
{
    public class Inventory
    {
        public int Id { get; init; }
        public required Item Item { get; init; }
        public required int Qty { get; set; }
        public required Location Location { get; set; }
    }
}