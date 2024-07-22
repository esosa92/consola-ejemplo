class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Resultado actual: 0");
        Console.Write("Ingresa una operacion a realizar: ");
        string operation = Console.ReadLine();
        Console.Write("Ingresa un numero: ");
        string a = Console.ReadLine();
        Console.Write("Ingresa el segundo numero: ");
        string b = Console.ReadLine();
        Calculator calc = new Calculator();
        double resultado = 0.0;
        if (operation == "1")
        {
            resultado = calc.Add(double.Parse(a), double.Parse(b));
        }
        if (operation == "2")
        {
            resultado = calc.Sub(double.Parse(a), double.Parse(b));
        }
        if (operation == "3")
        {
            resultado = calc.Multiply(double.Parse(a), double.Parse(b));
        }
        if (operation == "4")
        {
            resultado = calc.Divide(double.Parse(a), double.Parse(b));
        }
        Console.WriteLine("El resultado es: "+resultado);
        while (operation != "5")
        {
            Console.Write("Ingresa una operacion a realizar: ");
            operation = Console.ReadLine();
            Console.Write("Ingresa un numero: ");
            a = Console.ReadLine();
            if (operation == "1")
            {
                resultado = calc.Add(resultado, double.Parse(a));
            }
            if (operation == "2")
            {
                resultado = calc.Sub(resultado, double.Parse(a));
            }
            if (operation == "3")
            {
                resultado = calc.Multiply(resultado, double.Parse(a));
            }
            if (operation == "4")
            {
                resultado = calc.Divide(resultado, double.Parse(a));
            }
            Console.WriteLine("El resultado es: "+resultado);
        }
    }
}

class Calculator
{
    private double _lastResult = 0;
    
    public double Add(double a, double b)
    {
        _lastResult = a + b;
        return _lastResult;
    }

    public double Sub(double a, double b)
    {
        _lastResult = a - b;
        return _lastResult;
    }

    public double Multiply(double a, double b)
    {
        _lastResult = a * b;
        return _lastResult;
    }
    
    public double Divide(double a, double b)
    {
        _lastResult = a / b;
        return _lastResult;
    }

    public double GetLastResult()
    {
        return _lastResult;
    }
}