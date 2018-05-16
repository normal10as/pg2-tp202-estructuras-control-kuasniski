Module _2_4
    Sub main()
        Dim cant As Int16
        Dim precio, subt, desc, total As Double
        Console.Write("Ingrese cantidad:")
        cant = Console.ReadLine
        Console.Write("Ingrese precio:")
        precio = Console.ReadLine
        subt = cant * precio
        Console.WriteLine("Sub Total: $" & subt)

        If cant >= 10 And cant <= 50 Then
            Console.WriteLine("Se aplica 5% de descuento")
            desc = subt * 5 / 100

        ElseIf cant >= 51 And cant <= 250 Then
            Console.WriteLine("Se aplica 10% de descuento")
            desc = subt * 10 / 100
        ElseIf cant >= 251 Then
            Console.WriteLine("Se aplica 20% de descuento")
            desc = subt * 20 / 100
        Else
            total = subt
        End If
        total = subt - desc
        Console.WriteLine("Descuento: $" & desc)
        Console.WriteLine("Total: $" & total)
        Console.ReadKey()

    End Sub
End Module
