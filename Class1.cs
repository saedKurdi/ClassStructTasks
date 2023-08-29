public class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point()
    {
        this.x = default;
        this.y = default;
    }

    public int X { get; set; }

    public int Y
    {
        get { return this.y; }

        set
        {
            if (value > 0) this.x = value;

        }

    }

    public void ShowData()
    {
        Console.WriteLine($"x : {x} ");
        Console.WriteLine($"y : {y} ");
    }
}








public class Counter
{
    private int minimum;
    private int maximum;
    private int currentData;

    public Counter(int minimum, int maximum)
    {
        this.minimum = minimum;
        this.maximum = maximum;
    }

    public Counter()
    {
        this.minimum = default;
        this.maximum = default;
    }

    public int Min
    {
        get => this.minimum;

        set
        {
            if(value > 0)
                this.minimum = value;
            else
                this.minimum = default;
        }
    }

    public int Max
    {
        get => this.maximum;

        set
        {
            if (value > 0)
                this.minimum = value;
            else
                this.minimum = default;
        }
    }

    public int CurrentData
    {
        get => this.currentData;
    }


    public void IncrementAndShow()
    {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Magenta;
        currentData = Min;
        while (CurrentData <= Max)
        {
            Console.Clear();
            Console.WriteLine($"\t\t\t\t\t\t{CurrentData}  /  {Max} ");
            currentData++;
            Thread.Sleep(50);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }

    }

}


public class Fraction
{
    private float numerator; // suret 
    private float denumerator;// mexrec 

    public Fraction(int numerator, int denumerator)
    {
        this.numerator = numerator;
        if (denumerator != 0)
            this.denumerator = denumerator;
        else
            this.denumerator = 1;
    }

   public Fraction()
    {
        this.numerator = default;
        this.denumerator = 1;
    }

    public float Numerator
    {
        get => this.numerator;

        set => this.numerator = value;
    }

    public float Denumerator
    {
        get => this.denumerator;

        set
        {
            if (value != 0)
                this.denumerator = value;
        }
    }

    public void Reduction()
    {
        float cpy = Numerator;
       for (float i = cpy;i > 0;i--)
        {
            if(Denumerator % i == 0 && Numerator % i == 0)
            {
                Denumerator /= i;
                Numerator /= i;
                break;
            }
        }
       
    }

    public float Add()
    {
        Reduction();
        return Numerator + Denumerator;

    }

    public float Substraction()
    {
        Reduction();
        return Numerator - Denumerator ;
    }

    public float Mult()
    {
        Reduction();
        return Denumerator * Numerator;
    }

    public float Divide()
    {
        Reduction();
        return Numerator / Denumerator;
    }

    public void ShowFraction()
    {
        Console.WriteLine($"{Numerator}");
        Console.WriteLine($"--");
        Console.WriteLine($"{Denumerator}");
    }
}
