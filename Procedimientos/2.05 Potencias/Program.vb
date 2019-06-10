Imports System

Module Potencias
    Sub Main()
        Dim numero As Double
        Console.WriteLine("Ingrese el numero")
        numero = Console.ReadLine()
        Console.WriteLine(calcularPotencia(numero, 2))
        Console.WriteLine(calcularPotencia(numero, 3))
        Console.WriteLine(calcularPotencia(numero, 5))
    End Sub
    Function calcularPotencia(numero, aux) As Double
        Return Math.Pow(numero, aux)
    End Function
End Module
