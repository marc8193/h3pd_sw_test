using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    [Index(nameof(Description), IsUnique = true)]
    public class Stock
    {
        public int Id { get; init; }
        public string Description { get; init; } = String.Empty;
    }
}