Module _2_1
    Sub main()
        Dim a, b As Int16
        Console.Write("Ingrese un numero:")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo numero:")
        b = Console.ReadLine

        If a > b Then
            Console.Write("El primer numero es mayor")
        ElseIf a < b Then
            Console.Write("El segundo numero es mayor")
        Else
            Console.Write("Son Iguales")
        End If
        Console.ReadKey()

    End Sub
End Module
