class Program
{
    static void Main(string[] args)
    {
        //Programa que al iniciar nos pide que ingresemos 2 numeros (ingresa numero 1, ingresa numero 2)
        //El programa luego pasara a ejecutar cada uno de los metodos de la clase calculadora
        //Y mostrar el resultado en pantalla 
        //Punto bonus: Al inciar el progama en vez de pedirnos que ingresemos 2 numeros
        //Nos pedira que ingresemos un numero de operacion(Ingresa numero de operacion) 1 suma 2 es resta 3 es multiplicar 4 es dividir
        //En base al numero de operacion procederemos a realizar solo esa operacion.
        //Luego de mostrado los resultados el programa debe terminar.
    }
}

class Calculator
{
    public Calculator()
    {
    }

    private double _lastResult = 0;
    private static double _lastResultStatic = 0;

    public static string Sarasa()
    {
        return "Sarasa";
    }

    //[Modificadores de access por defecto es internal]
    public double Add(double a, double b)
    {
        _lastResult = a + b;
        _lastResultStatic = a + b;
        return _lastResult;
    }

    public double Sub(double a, double b)
    {
        _lastResult = a - b;
        _lastResultStatic = a + b;
        return _lastResult;
    }

    public double Multiply(double a, double b)
    {
        _lastResult = a * b;
        _lastResultStatic = a + b;
        return _lastResult;
    }
    
    public double Divide(double a, double b)
    {
        _lastResult = a / b;
        _lastResultStatic = a + b;
        return _lastResult;
    }

    public double GetLastResult()
    {
        return _lastResult;
    }

    public double GetLastResultStatic()
    {
        return _lastResultStatic;
    }
}

class Persona
{
    private string _name;
    private string _surname;
    private int _age;

    public Persona(string name, string surname, int age)
    {
        _name = name;
        _surname = surname;
        _age = age;
    }

    public void SayHi()
    {
        Console.WriteLine($"Hola me llamo {_name} {_surname} y tengo {_age}");
    }
}