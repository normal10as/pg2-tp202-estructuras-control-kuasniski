Module _2_6
    Sub main()
        Dim cant As Int16
        Dim precio, subt, desc, total As Double
        Console.Write("Ingrese cantidad:")
        cant = Console.ReadLine
        Console.Write("Ingrese precio:")
        precio = Console.ReadLine
        subt = cant * precio
        Console.WriteLine("Sub Total :" & subt)

        Select Case cant
            Case 10 To 50
                Console.WriteLine("Se aplica 5% de descuento")
                desc = subt * 5 / 100
            Case 51 To 250
                Console.WriteLine("Se aplica 10% de descuento")
                desc = subt * 10 / 100
            Case >= 251
                Console.WriteLine("Se aplica 20% de descuento")
                desc = subt * 20 / 100
            Case Else
                total = subt
        End Select
        total = subt - desc
        Console.WriteLine("Descuento: " & desc)
        Console.WriteLine("Total: " & total)
        Console.ReadKey()

    End Sub
End Module
