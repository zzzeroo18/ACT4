using System;
namespace act4{
class Program
{
    static void Main()
    {
        // 1. calcular el area de un rectangulo (base * altura).
        Console.WriteLine("consigna 1");
        int baserectangulo = 8;
        int alturarectangulo = 4;
        int resultadoarea = baserectangulo * alturarectangulo;
        Console.WriteLine($"el area del rectangulo es: {resultadoarea}");


        // 2. calcular el resto de 100 dividido 7 con %.
        Console.WriteLine("consigna 2");
        int residuo = 100 % 7;
        Console.WriteLine($"resto de 100 % 7: {residuo}");


        // 3. convertir temperatura de celsius a fahrenheit: f = c * 9/5 + 32.
        Console.WriteLine("consigna 3");
        double tempcelsius = 25;
        double tempfahrenheit = tempcelsius * 9 / 5 + 32;
        Console.WriteLine($"{tempcelsius}°c equivalen a: {tempfahrenheit}°f");


        // 4. usar int.parse para convertir un string numerico.
        Console.WriteLine("consigna 4");
        string textonum = "456";
        int numparseado = int.Parse(textonum);
        Console.WriteLine($"numero parseado: {numparseado}");


        // 5. usar double.tryparse y manejar el caso donde falla.
        Console.WriteLine("consigna 5");
        string inputusuario = "12.34a";
        if (double.TryParse(inputusuario, out double numdouble))
        {
            Console.WriteLine($"conversion exitosa: {numdouble}");
        }
        else
        {
            Console.WriteLine($"error: '{inputusuario}' no es un numero double valido.");
        }


        // 6. calcular precio final con iva (precio * 1.21).
        Console.WriteLine("consigna 6");
        double preciooriginal = 1000.0;
        double preciofinaliva = preciooriginal * 1.21;
        Console.WriteLine($"precio con iva: {preciofinaliva}");


        // 7. demostrar diferencia entre division entera (int/int) y real (double).
        Console.WriteLine("consigna 7");
        int resultadoentero = 7 / 2;
        double resultadoreal = 7.0 / 2.0;
        Console.WriteLine($"division entera (7/2): {resultadoentero} | division real (7.0/2.0): {resultadoreal}");


        // 8. usar ++ para incrementar un contador en un solo paso.
        Console.WriteLine("consigna 8");
        int numcontador = 0;
        numcontador++;
        Console.WriteLine($"contador incrementado: {numcontador}");


        // 9. convertir double a int con cast explicito (int).
        Console.WriteLine("consigna 9");
        double decimalito = 18.95;
        int entero = (int)decimalito;
        Console.WriteLine($"double original: {decimalito} | int casteado: {entero}");


        // 10. calcular cuantos dias completos hay en 1000 horas.
        Console.WriteLine("consigna 10");
        int canthoras = 1000;
        int dias = canthoras / 24;
        Console.WriteLine($"dias completos en 1000 horas: {dias}");
    }
}
}