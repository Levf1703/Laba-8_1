//// лаба 8_1
try
{
    Console.Write("Введите целую часть 1-ого чилса: ");
    int number_int1 = int.Parse(Console.ReadLine());
    Console.Write("Введите дробную часть 1-ого чилса: ");
    string number_float1 = Console.ReadLine();
    while (number_float1.Length > 2)
    {
        Console.WriteLine("Неверный ввод!");
        Console.Write("Введите дробную часть 1-ого чилса: ");
        number_float1 = Console.ReadLine();
    }
    Console.Write("Введите целую часть 2-ого чилса: ");
    int number_int2 = int.Parse(Console.ReadLine());
    Console.Write("Введите дробную часть 2-ого чилса: ");
    string number_float2 = Console.ReadLine();
    while (number_float2.Length > 2)
    {
        Console.WriteLine("Неверный ввод!");
        Console.Write("Введите дробную часть 1-ого чилса: ");
        number_float2 = Console.ReadLine();
    }
    Console.Write("Введите любое дробное число: ");
    double fraction = double.Parse(Console.ReadLine());
    INumbers numbers = new Money(number_int1, number_float1, number_int2, number_float2, fraction);
    numbers.AddNumbers();
    numbers.SubtractNumbers();
    numbers.DivisionNumbers();
    numbers.DivisionByFraction();
    numbers.MultiplyByFraction();
    numbers.Compare();
    numbers.Print();
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}

interface INumbers
{
    double AddNumbers();
    double SubtractNumbers();
    double DivisionNumbers();
    double DivisionByFraction();
    double MultiplyByFraction();
    string Compare();
    void Print();
}

abstract class Numbers : INumbers
{
    protected int number_int1;
    protected string number_float1;
    protected int number_int2;
    protected string number_float2;
    protected double number1;
    protected double number2;
    protected double fraction;

    public virtual double AddNumbers()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        return (number1 + number2);
    }

    public virtual double SubtractNumbers()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        return (number1 - number2);
    }

    public virtual double DivisionNumbers()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        return (number1 / number2);
    }
    public virtual double DivisionByFraction()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        return (number1 + number2) / fraction;
    }
    public virtual double MultiplyByFraction()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        return (number1 + number2) * fraction;
    }
    public virtual string Compare()
    {
        number1 = double.Parse($"{number_int1},{number_float1}");
        number2 = double.Parse($"{number_int2},{number_float2}");
        if (number1 > number2)
            return "1-ое число больше 2-ого";
        if (number1 == number2)
            return "Числа равны";
        return "2-ое число больше 1-ого";
    }
    public abstract void Print();
}
class Money : Numbers
{
    private double sum;
    private double sub;
    private double div;
    private double div_frac;
    private double multy;
    private string result;
    public Money(int number_int1, string number_float1, int number_int2, string number_float2, double fraction) : base()
    {
        this.number_int1 = number_int1;
        this.number_float1 = number_float1;
        this.number_int2 = number_int2;
        this.number_float2 = number_float2;
        this.fraction = fraction;
    }
    public override double AddNumbers()
    {
        sum = base.AddNumbers();
        return sum;
    }
    public override double SubtractNumbers()
    {
        sub = base.SubtractNumbers();
        return sub;
    }
    public override double DivisionNumbers()
    {
        div = base.DivisionNumbers();
        return div;
    }
    public override double DivisionByFraction()
    {
        div_frac = base.DivisionByFraction();
        return div_frac;
    }
    public override double MultiplyByFraction()
    {
        multy = base.MultiplyByFraction();
        return multy;
    }
    public override string Compare()
    {
        result = base.Compare();
        return result;
    }
    public override void Print()
    {
        Console.WriteLine($"Сумма: {sum}; Разность: {sub}; Частное: {div}; Частное от числа: {div_frac}; Произведение: {multy}; Сравнение: {result}");
    }
}