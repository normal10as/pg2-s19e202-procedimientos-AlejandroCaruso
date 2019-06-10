Imports System

Module Sumas
    Sub Main()
        Console.WriteLine(Sumar(7, 9))
        Console.WriteLine(Sumar(5, 6, 2))
        Console.WriteLine(Sumar(4, 3, 8, 1))
    End Sub
    Function Sumar(valor1, valor2) As Double
        Return valor1 + valor2
    End Function
    Function Sumar(valor1, valor2, valor3) As Double
        Return Sumar(Sumar(valor1, valor2), valor3)
    End Function
    Function Sumar(valor1, valor2, valor3, valor4) As Double
        Return Sumar(Sumar(valor1, valor2), Sumar(valor3, valor4))
    End Function
End Module
