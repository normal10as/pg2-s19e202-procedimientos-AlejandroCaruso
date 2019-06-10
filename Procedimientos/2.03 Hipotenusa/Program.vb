Imports System.Math

Module Hipotenusa
    Sub Main()
        Dim lado1, lado2, hipotenusa As Double
        Console.WriteLine("Ingrese un cateto")
        lado1 = Console.ReadLine()
        Console.WriteLine("Ingrese el otro cateto")
        lado2 = Console.ReadLine()
        hipotenusa = calcularHipotenusa(lado1, lado2)
        Console.WriteLine("Hipotenusa: {0} ", hipotenusa)
    End Sub
    Function calcularHipotenusa(ladoA, ladoB) As Double
        Return Math.Sqrt(Math.Pow(ladoA, 2) + Math.Pow(ladoB, 2))
    End Function
End Module
