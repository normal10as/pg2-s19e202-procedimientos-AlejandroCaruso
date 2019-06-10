Imports System

Module Nueva_Fecha
    Sub Main()
        Dim fecha, fechaModificada As Date
        Dim dias As Byte
        Console.WriteLine("Ingrese la fecha (dd/mm/yyyy)")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese los dias por agregar")
        dias = Console.ReadLine()
        fechaModificada = AgregarDias(fecha, dias)
        Console.WriteLine("Fecha Modificada: " & fechaModificada)
    End Sub
    Function AgregarDias(fecha As Date, dias As Double) As Date
        Return fecha.AddDays(dias)
    End Function
End Module
