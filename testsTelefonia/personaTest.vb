Imports TelefoniaEntidades

Module personaTest
    Sub main()
        Dim marca1 As New Marca("xiaomi")
        Dim modelo1 As New Modelo("redMi", marca1)
        Dim equi As New Equipo(modelo1, "15487afd99")
        Dim cliente1 As New Persona(100001, "simpson", "homero", 25678900)
        Dim linea1 As New Linea(555, 123456, equi, cliente1)
        Dim linea2 As New Linea(555, 99999, equi, cliente1)
        linea2.suspender()
        cliente1.addLinea(linea1)
        cliente1.addLinea(linea2)
        Console.WriteLine(cliente1.ToString)
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine(linea)
        Next
        cliente1.removeLinea(linea2)
        Console.WriteLine("----------")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine(linea)
        Next
    End Sub



End Module
