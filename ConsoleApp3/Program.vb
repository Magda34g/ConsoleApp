Imports System

Module program
    Class Playera

        Public SAM As Integer
        Private talla As String
        Private tcost(10) As Integer
        Private dCost(10) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Public Sub IngresarDatos()
            Console.WriteLine("�Cu�l es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("�Cu�l es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("�Cu�l es costo del hilo por metro?")
            costohilo = Console.ReadLine
            For f = 0 To 10
                Console.Write("�Cu�l es el Tiempo de la costura?:" & f)
                tcost(f) = Console.ReadLine()
            Next


            For f = 0 To 10
                Console.Write("�Cu�l es la distancia de costura?:" & f)
                dCost(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)
            Console.WriteLine("Tiempo de la costura: " & tcost(10))
            Console.WriteLine("Tiempo de la distancia: " & dCost(10))

        End Sub
        Public Function Tiempototal()
            SAM = tcost(10)
            Return SAM
        End Function
        Public Function dtCostura()
            dtotalCostura = dCost(10)
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            cantHilo = dCost(10) * 2 + dCost(10) * 2 * 0.05
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            costototal = (((dCost(10) * 2 + (dCost(10)) * 2 * 0.05) * costohilo) + (tcost(10)) * costominuto)
            Return costototal
        End Function
    End Class
    Sub Main(args As String())
        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New Playera()
        playera1.IngresarDatos()
        Dim playera2 As New Playera()
        playera1.IngresarDatos()
        Dim playera3 As New Playera()
        playera1.IngresarDatos()
        Dim playera4 As New Playera()
        playera1.IngresarDatos()
        Dim playera5 As New Playera()
        playera1.IngresarDatos()


        mhilonecesarios = playera1.cantidadHilo() + playera2.cantidadHilo() + playera3.cantidadHilo() + playera4.cantidadHilo() + playera5.cantidadHilo()
        tfabricacion = playera1.Tiempototal() + playera1.Tiempototal() + playera2.Tiempototal() + playera3.Tiempototal() + playera4.Tiempototal() + playera5.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera() + playera2.CostoTotalPlayera() + playera3.CostoTotalPlayera() + playera4.CostoTotalPlayera() + playera5.CostoTotalPlayera()

        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricaci�n es : " & tfabricacion)
        Console.WriteLine("El costo de fabricaci�n es: " & Costofabricacion)


    End Sub

End Module
