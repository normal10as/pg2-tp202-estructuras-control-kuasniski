Module _2_10
    Sub main()
        Dim a, b, r, cont As Int16
        a = 5
        b = 30

        Console.WriteLine(" Para a={0} y b={1}", a, b)
        Console.WriteLine("For:")
        For i = a To b
            If r = i Mod 5 Then
                cont += 1
            End If
        Next
        Console.WriteLine("Existen {0} números multiplos de 5 entre a y b", cont)

        Console.WriteLine("Do While:")
        cont = 0
        b = 5
        Do While b <= 30
            If r = b Mod 5 Then
                cont += 1
            End If
            b += 1
        Loop
        Console.WriteLine("Existen {0} números multiplos de 5 entre a y b", cont)
        Console.WriteLine("Loop While:")
        cont = 0
        b = 5
        Do
            If r = b Mod 5 Then
                cont += 1
            End If
            b += 1
        Loop While b <= 30
        Console.WriteLine("Existen {0} números multiplos de 5 entre a y b", cont)
        Console.WriteLine("Do Until:")
        b = 5
        cont = 0
        Do Until b > 30
            If r = b Mod 5 Then
                cont += 1
            End If
            b += 1
        Loop
        Console.WriteLine("Existen {0} números multiplos de 5 entre a y b", cont)
        Console.WriteLine("loop Until:")
        b = 5
        cont = 0
        Do
            If r = b Mod 5 Then
                cont += 1
            End If
            b += 1
        Loop Until b > 30
        Console.WriteLine("Existen {0} números multiplos de 5 entre a y b", cont)
        Console.ReadKey()
    End Sub
End Module
