using techmath;


/***********************/
/* Fraction part       */
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
/* Shape part          */
/***********************/

Rectangle r1 = new(10, 5);

Console.WriteLine("r1:             " + r1);
Console.WriteLine("r1.Perimeter(): " + r1.Perimeter());
Console.WriteLine("r1.Area():      " + r1.Area());

Circle c1 = new(5);

Console.WriteLine("c1:             " + c1);
Console.WriteLine("c1.Perimeter(): " + c1.Perimeter());
Console.WriteLine("c1.Area():      " + c1.Area());

RightTriangle rt1 = new(3, 4, 5);

Console.WriteLine("rt1:             " + rt1);
Console.WriteLine("rt1.Perimeter(): " + rt1.Perimeter());
Console.WriteLine("rt1.Area():      " + rt1.Area());

Console.WriteLine();

/***********************/
/* QuadraticFormula    */
/***********************/


QuadraticFormula qf;

int a = 1, b = 2, c = -1;

qf = new QuadraticFormula(a, b, c);


Console.WriteLine("A: " + a);
Console.WriteLine("B: " + b);
Console.WriteLine("C: " + c);

Console.WriteLine("D: " + qf.GetD().ToString());

Console.WriteLine("S: " + qf.GetS().ToString());
Console.WriteLine("T: " + qf.GetT().ToString());


if (qf.GetD() < 0)
{
    Console.WriteLine("No solutuions");
}

else if (qf.GetD() == 0)
{
    Console.WriteLine("X: " + qf.GetX1().ToString());
}
else if (qf.GetD() > 0)
{
    Console.WriteLine("Kvardratrod D: " + qf.GetSqrtD().ToString());
    Console.WriteLine("X1: " + qf.GetX1().ToString());
    Console.WriteLine("X2: " + qf.GetX2().ToString());
}

Console.WriteLine();

// to do
// IO.WaitForEscape();

#if DEBUG
Console.ReadLine();
#endif