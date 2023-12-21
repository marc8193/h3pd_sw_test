using techmath;

/***********************/
// Fraction part       */
/***********************/

Fraction f1 = new(-3, 4);
Console.WriteLine("f1: " + f1);

Fraction f2 = new(1, 4);
Console.WriteLine("f2: " + f2);

Console.WriteLine("f1.Divide(f2):   " + f1.Divide(f2));
Console.WriteLine("f1.Multiply(f2): " + f1.Multiply(f2));
Console.WriteLine("f1.Minus(f2):    " + f1.Minus(f2));
Console.WriteLine("f1.Add(f2):      " + f1.Add(f2));

Console.WriteLine();

/***********************/
// Shape part          */
/***********************/

/***********************/
// QuadraticFormula    */
/***********************/


QuadraticFormula qf;

int a = 1, b = 2, c = -1;

qf = new QuadraticFormula(a, b, c);


Console.WriteLine("A: " + a);
Console.WriteLine("B: " + b);
Console.WriteLine("C: " + c);


Console.WriteLine("D: " + qf.GetD().ToString());
if (qf.GetD() < 0)
{
    Console.WriteLine("S: " + qf.GetS().ToString());
    Console.WriteLine("T: " + qf.GetT().ToString());
}

else if (qf.GetD() == 0)
{
    Console.WriteLine("X: " + qf.GetX1().ToString());
    Console.WriteLine("S: " + qf.GetS().ToString());
    Console.WriteLine("T: " + qf.GetT().ToString());
}
else if (qf.GetD() > 0)
{
    Console.WriteLine("Kvardratrod D: " + qf.GetSqrtD().ToString());
    Console.WriteLine("X1: " + qf.GetX1().ToString());
    Console.WriteLine("X2: " + qf.GetX2().ToString());
    Console.WriteLine("S: " + qf.GetS().ToString());
    Console.WriteLine("T: " + qf.GetT().ToString());
}

Console.WriteLine();


#if DEBUG
Console.ReadLine();
#endif

