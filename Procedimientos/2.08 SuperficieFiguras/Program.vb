Imports System

Module SuperficieFiguras
    Sub Main()
        Console.WriteLine("Cuadrado: {0}", CalcularArea(7))
        Console.WriteLine("Rectangulo: {0}", CalcularArea(5, 8))
        Console.WriteLine("Trapecio: {0}", CalcularArea(9, 2, 7))
    End Sub
    Function CalcularArea(lado) As Double
        Return CalcularArea(lado, lado)
    End Function
    Function CalcularArea(base, altura) As Double
        Return CalcularArea(base, base, altura)
    End Function
    Function CalcularArea(base1, base2, altura) As Double
        Return (base1 + base2) * altura / 2
    End Function
End Module
