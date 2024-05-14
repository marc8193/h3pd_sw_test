using System;

namespace EFCoreExample
{
    public class Customer
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public required string? Address1 { get; init; }
        public string? Address2 { get; init; } = String.Empty;

        public string? ZipCode { get; init; }
        public string? Country { get; init; }

    }
}