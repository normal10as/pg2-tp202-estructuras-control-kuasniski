Module _2_14
    Sub main()
        Dim cant As Int16
        Dim precio, subt, desc, total, totalGral, totalDesc As Double
        Do
            Console.Write("Ingrese cantidad(0=Fin):")
            cant = Console.ReadLine
            If cant <> 0 Then
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
                totalDesc += desc
                totalGral += total
                Console.WriteLine("Descuento: $" & desc)
                Console.WriteLine("Total: $" & total)
            End If

        Loop Until cant = 0
        Console.Clear()
        Console.WriteLine("total de descuento: ${0}", totalDesc)
        Console.WriteLine("Total a cobrar: ${0}", totalGral)
        Console.ReadKey()

    End Sub
End Module
