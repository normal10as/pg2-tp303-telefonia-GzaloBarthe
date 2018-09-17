Imports TelefoniaEntidades

Module testLinea

    Sub Main()
        Dim lin As New Linea(0, 0)
        lin.CodigoArea = 987
        lin.Numero = 123456
        Console.WriteLine(lin.ToString)
        lin.suspender()
        Console.WriteLine(lin.ToString)
        lin.reactivar()
        Console.WriteLine(lin.ToString)
    End Sub

End Module
