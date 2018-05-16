Module _2_7
    Sub main()
        Dim grados As Int16

        Console.Write("Ingrese tamaño del angulo: ")
        grados = Console.ReadLine()

        Select Case grados

            Case 0 To 89
                Console.WriteLine("Agudo")
            Case 90
                Console.WriteLine("Recto")
            Case 90 To 179
                Console.WriteLine("Obtuzo")
            Case 180
                Console.WriteLine("Llano")
            Case 180 To 360
                Console.WriteLine("Cóncavo")
            Case Else
                Console.WriteLine("Error")
        End Select

        Console.ReadKey()

    End Sub
End Module
