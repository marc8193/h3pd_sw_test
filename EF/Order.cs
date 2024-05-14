using System;

namespace EFCoreExample
{
    public class Order
    {
        public int Id { get; init; }
        public string? Description { get; init; }
        public List<OrderLine> OrderLines { get; init; } = new List<OrderLine>();
        public double? Discount { get; init; }
        public required Customer Customer { get; init; }

        // public enum State Open, Closed
  }
}