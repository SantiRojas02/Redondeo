Module Module1

    Sub Main(args As String())
        Dim numero, Redondeo, defecto As Integer



        Console.Write("Ingrese un numero real: ")
        numero = Console.ReadLine()

        Redondeo = Math.Round(numero)
        defecto = numero


        Console.WriteLine("Numero redondeado: " & Redondeo)
        Console.WriteLine("Numero por defecto: " & defecto)


        Console.ReadKey()



    End Sub

End Module
