Module _2_13
    Sub main()
        Dim r As Int16
        Dim esprimo As Boolean = True
        For i = 2 To 1000
            For j = 2 To 1000
                If r = i Mod j And Not i = j Then
                    esprimo = False
                    Exit For
                End If
            Next
            If esprimo Then
                Console.WriteLine(i)
            ElseIf Not esprimo Then
                esprimo = True
            End If
        Next
        Console.ReadKey()

    End Sub
End Module
