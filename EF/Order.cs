using System;

namespace EFCoreExample
{
  public enum OrderState
{
    New = 1,
    Done = 2
};
    public class Order
    {
        public int Id { get; init; }
        public string? Description { get; init; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public double? Discount { get; set; }
        public required Customer Customer { get; set; }

        public OrderState State { get; set; } = OrderState.New;
  }
}