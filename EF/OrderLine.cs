using System;

namespace EFCoreExample
{
    public class OrderLine
    {
        public int Id { get; init; }
        public required Item Item { get; init; }
        public required int Qty { get; init; }
    }
}