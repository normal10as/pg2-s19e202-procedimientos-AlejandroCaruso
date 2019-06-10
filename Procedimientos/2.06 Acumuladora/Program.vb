Imports System

Module Acumuladora
    Friend valor As Double
    Sub Main()
        Acumular(valor)
        Acumular(valor)
        Acumular(valor)
    End Sub
    Sub Acumular(ByRef valor As Double)
        Dim acumulador As Double
        Console.WriteLine("Ingresar valor a acumular")
        acumulador = Console.ReadLine()
        valor = valor + acumulador
        Console.WriteLine("Valor acumulado: {0}", valor)
    End Sub
End Module
