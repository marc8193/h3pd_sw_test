using System;

namespace EFCoreExample
{
    // Each location belongs to a Stock and have an Aisle and a Zone, think of it as (X,Y)
    public class Location
    {
        public int Id { get; init; }
        public required Stock Stock { get; init; }
        public int? Aisle { get; init; }
        public int? Zone { get; init; }
    }
}