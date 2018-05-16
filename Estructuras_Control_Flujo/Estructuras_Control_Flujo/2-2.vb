Module _2_2
    Sub main()
        Dim a, b, c As Int16


        Console.Write("Ingrese un numero:")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo numero:")
        b = Console.ReadLine
        Console.Write("Ingrese el tercer numero:")
        c = Console.ReadLine
        If a < b And a < c Then
            Console.Write("El menor es: " & a)
        ElseIf b < c Then
            Console.Write("El menor es: " & b)
        Else
            Console.Write("El menor es: " & c)
        End If
        Console.ReadKey()
    End Sub
End Module
