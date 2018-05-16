Module _2_15
    Sub main()
        Dim capital, intereses, saldo, t_intereses As Double
        Dim meses As Int16

        Console.Write("Ingrese capital inicial:")
        capital = Console.ReadLine
        Console.Write("Ingrese cantidad de meses a calcular:")
        meses = Console.ReadLine
        Console.Clear()
        Console.WriteLine("Meses  |   Capital   |  Intereses  |   Saldo")
        intereses = (capital * 36 / 100) / 12
        For i = 1 To meses
            saldo = capital + intereses
            Console.WriteLine("{0 }     |{1}         |{2}          |{3}", i, capital, intereses, saldo)
            capital = saldo
            t_intereses += intereses
        Next
        Console.WriteLine("Total de Intereses ganados:" & t_intereses)
        Console.ReadKey()

    End Sub
End Module
