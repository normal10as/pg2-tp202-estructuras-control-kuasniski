Module _2_8
    Sub main()
        Dim mes, year, cant_dias As Integer

        Console.Write("Ingrese numero de mes:")
        mes = Console.ReadLine
        If mes = 2 Then
            Console.Write("Ingrese el año ej. AAAA:")
            year = Console.ReadLine
            cant_dias = DateTime.DaysInMonth(year, mes)
            Console.Write("El mes {0} del año {1} tiene {2} dias", mes, year, cant_dias)
        Else
            'como solo se pide el año en el caso de febrero se usa el 2018
            cant_dias = DateTime.DaysInMonth(2018, mes)
            Console.WriteLine("El mes {0} del corriente año tiene {1} dias", mes, cant_dias)
        End If

        Console.ReadKey()

    End Sub
End Module
