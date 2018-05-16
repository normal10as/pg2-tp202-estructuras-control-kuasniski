Module _2_12
    Sub main()
        Dim a, b, c As Int16
        a = 0
        b = 1
        Console.WriteLine(a)
        Console.WriteLine(b)
        For i = 1 To 20
            c = a + b
            Console.WriteLine(c)
            a = b
            b = c
        Next
        Console.ReadKey()

    End Sub
End Module
