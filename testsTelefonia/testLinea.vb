Imports TelefoniaEntidades

Module testLinea

    Sub Main()
        Dim marca1 As New Marca("xiaomi")
        Dim modelo1 As New Modelo("redMi", marca1)
        Dim equi As New Equipo(modelo1, "15487afd99")
        Dim cliente1 As New Persona(100001, "simpson", "homero", 25678900)
        Dim lin As New Linea(0, 0, equi, cliente1)
        lin.CodigoArea = 987
        lin.Numero = 123456
        Console.WriteLine("equipo:" & lin.Equipo.ToString)
        Console.WriteLine("modelo:" & lin.Equipo.Modelo.ToString)
        Console.WriteLine("marca:" & lin.Equipo.Modelo.Marca.ToString)
        Console.WriteLine(lin.ToString)
        lin.suspender()
        Console.WriteLine(lin.ToString)
        lin.reactivar()
        Console.WriteLine(lin.ToString)
    End Sub

End Module
