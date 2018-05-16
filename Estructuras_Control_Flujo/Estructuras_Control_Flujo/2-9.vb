Module _2_9
    Sub main()
        Dim opc As Int16
        Dim tipo_dato As String
        Dim valor, pies, pulgadas, yardas, metros, cm As Double
        Console.WriteLine("¿Que valor desea convertir?")
        Console.Write("1=Pies 2=Pulgadas 3=Yardas 4=Metros 5=Centimentros: ")
        opc = Console.ReadLine
        Console.Write("Ingrese el valor a convertir:")
        valor = Console.ReadLine

        Select Case opc
            Case 1
                tipo_dato = "Pies"
                pulgadas = valor * 12
                yardas = valor / 3
                cm = valor * 12 * 2.54
                metros = 1 * cm / 100
                pies = valor
            Case 2
                tipo_dato = "Pulgadas"
                pies = valor / 12
                yardas = pies * 1 / 3
                cm = valor * 2.54
                metros = 1 * cm / 100
                pulgadas = valor
            Case 3
                tipo_dato = "Yardas"
                pies = valor * 3
                pulgadas = pies * 12
                cm = pulgadas * 2.54
                metros = 1 * cm / 100
                yardas = valor
            Case 4
                tipo_dato = "Metros"
                pulgadas = valor * 100 / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                cm = valor * 100
                metros = valor
            Case 5
                tipo_dato = "Centimetros"
                pulgadas = valor / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                metros = valor / 100
                cm = valor
        End Select
        Console.Clear()
        Console.WriteLine("{0} {1} equivalen a:", valor, tipo_dato)
        Console.WriteLine("{0} Pulgadas", pulgadas)
        Console.WriteLine("{0} Pies", pies)
        Console.WriteLine("{0} Yardas", yardas)
        Console.WriteLine("{0} Metros", metros)
        Console.WriteLine("{0} Centimetros", cm)
        Console.ReadKey()

    End Sub
End Module
