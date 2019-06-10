Imports System.Math

Module VolumenCilindro
    Sub Main()
        Dim radioBase, altura, volumen As Double
        Console.WriteLine("Ingrese radio: ")
        radioBase = Console.ReadLine()
        Console.WriteLine("Ingrese altura: ")
        altura = Console.ReadLine()
        volumen = CalcularVolumen(radioBase, altura)
        Console.WriteLine("El volumen del cilindro es de {0}", volumen)
    End Sub
    Function CalcularVolumen(radio, altura) As Double
        Return (Math.PI) * radio * altura
    End Function
End Module
