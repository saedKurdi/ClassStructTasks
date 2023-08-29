//  task 1 
//Point point = new Point(4,2);
//point.ShowData();


//  task 2
//Counter c = new Counter(50, 200);
//c.IncrementAndShow();

//  task 3 

Fraction f = new Fraction(40, 85);
Console.WriteLine($"Evvel : ");
f.ShowFraction();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sonra : ");
f.Reduction();
f.ShowFraction();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Kesrin suret ve mexrecinin cemi : {f.Add()} ");
Console.WriteLine($"Kesrin suret ve mexrecinin ferqi : {f.Substraction()} ");
Console.WriteLine($"Kesrin suret ve mexrecinin hasili : {f.Mult()} ");
Console.WriteLine($"Kesrin suret ve mexrecinin nisbeti : {f.Divide()} ");