Module _2_3
    Sub main()
        Dim a, b, c, d, e As Int16

        Console.Write("Ingrese uel primer número:")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo número:")
        b = Console.ReadLine
        Console.Write("Ingrese el tercer número:")
        c = Console.ReadLine
        Console.Write("Ingrese el cuarto número:")
        d = Console.ReadLine
        Console.Write("Ingrese el quinto número:")
        e = Console.ReadLine

        If a > b And a > c And a > d And a > e Then
            Console.Write("El primer número es el de mayor valor")
        ElseIf b > c And b > d And b > e Then
            Console.Write("El segundo número es el de mayor valor")
        ElseIf c > d And c > e Then
            Console.Write("El tecer número es el de mayor valor")
        ElseIf d > e Then
            Console.Write("El cuarto número es el de mayor valor")
        Else
            Console.Write("El quinto número es el de mayor valor")
        End If
        Console.ReadKey()
    End Sub
End Module
