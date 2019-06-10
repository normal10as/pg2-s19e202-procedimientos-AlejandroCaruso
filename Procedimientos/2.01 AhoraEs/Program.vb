Imports System.DateTime

Module AhoraEs
    Sub Main()
        Dim hora As Int16
        imprimirFecha()
        hora = horaActual()
        Console.WriteLine("Hora actual: " & hora)
    End Sub

    Sub imprimirFecha()
        Console.WriteLine("Hoy es: " & Date.Now)
    End Sub
    Function horaActual()
        Return (Now.Hour)
    End Function

End Module
