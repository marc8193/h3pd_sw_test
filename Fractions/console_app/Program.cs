using techmath;

Fraction f1 = new(-3, 4);
Console.WriteLine("f1: " + f1);

Fraction f2 = new(1, 4);
Console.WriteLine("f2: " + f2);

Console.WriteLine("f1.Divide(f2):   " + f1.Divide(f2));
Console.WriteLine("f1.Multiply(f2): " + f1.Multiply(f2));
Console.WriteLine("f1.Minus(f2):    " + f1.Minus(f2));
Console.WriteLine("f1.Add(f2):      " + f1.Add(f2));

#if DEBUG
  Console.ReadLine();
#endif

