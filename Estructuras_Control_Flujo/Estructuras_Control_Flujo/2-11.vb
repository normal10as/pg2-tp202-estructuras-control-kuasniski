Module _2_11
    Sub main()
        Dim num, cantPar, cantImp, r As Int16
        Do
            Console.Write("Ingrese un número: ")
            num = Console.ReadLine
            If r = num Mod 2 And num > 0 Then
                cantPar += 1
            ElseIf Not r = num Mod 2 And num > 0 Then
                cantImp += 1
            End If
        Loop While num > 0
        Console.Clear()

        If cantImp = 0 Then
            Console.WriteLine("Todos los valores ingresados son pares")
        ElseIf cantPar = 0 Then
            Console.WriteLine("Todos los valores ingresados son impares")
        Else
            Console.WriteLine("Los valores ingresados son: {0} pares y {1} impares", cantPar, cantImp)
        End If
        Console.ReadKey()

    End Sub
End Module
