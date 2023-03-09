Imports System

Module Program

    Class Playera

        Private SAM As Integer
        Private talla As String
        Private tCost1, tCost2, tCost3, tCost4, tCost5, tCost6, tCost7, tCost8, tCost9, tCost10, tCost11 As Integer
        Private dCost1, dCost2, dCost3, dCost4, dCost5, dCost6, dCost7, dCost8, dCost9, dCost10, dCost11 As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer

        Public Sub IngresarDatos()
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 1?")
            tCost1 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 2?")
            tCost2 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 3?")
            tCost3 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 4?")
            tCost4 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 5?")
            tCost5 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 6?")
            tCost6 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 7?")
            tCost7 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 8?")
            tCost8 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 9?")
            tCost9 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 10?")
            tCost10 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Tiempo de la costura 11?")
            tCost11 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 1?")
            dCost1 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 2?")
            dCost2 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 3?")
            dCost3 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 4?")
            dCost4 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 5?")
            dCost5 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 6?")
            dCost6 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 7?")
            dCost7 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 8?")
            dCost8 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 9?")
            dCost9 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 10?")
            dCost10 = Console.ReadLine
            Console.WriteLine("¿Cuál es el Distancia de la costura 11?")
            dCost11 = Console.ReadLine
        End Sub
        Public Sub MostrarDatos()
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)
            Console.WriteLine("Tiempo de la costura 1: " & tCost1)
            Console.WriteLine("Tiempo de la costura 2: " & tCost2)
            Console.WriteLine("Tiempo de la costura 3: " & tCost3)
            Console.WriteLine("Tiempo de la costura 4: " & tCost4)
            Console.WriteLine("Tiempo de la costura 5: " & tCost5)
            Console.WriteLine("Tiempo de la costura 6: " & tCost6)
            Console.WriteLine("Tiempo de la costura 7: " & tCost7)
            Console.WriteLine("Tiempo de la costura 8: " & tCost8)
            Console.WriteLine("Tiempo de la costura 9: " & tCost9)
            Console.WriteLine("Tiempo de la costura 10: " & tCost10)
            Console.WriteLine("Tiempo de la costura 11: " & tCost11)
            Console.WriteLine("Tiempo de la distancia 1: " & dCost1)
            Console.WriteLine("Tiempo de la distancia 2: " & dCost2)
            Console.WriteLine("Tiempo de la distancia 3: " & dCost3)
            Console.WriteLine("Tiempo de la distancia 4: " & dCost4)
            Console.WriteLine("Tiempo de la distancia 5: " & dCost5)
            Console.WriteLine("Tiempo de la distancia 6: " & dCost6)
            Console.WriteLine("Tiempo de la distancia 7: " & dCost7)
            Console.WriteLine("Tiempo de la distancia 8: " & dCost8)
            Console.WriteLine("Tiempo de la distancia 9: " & dCost9)
            Console.WriteLine("Tiempo de la distancia 10: " & dCost10)
            Console.WriteLine("Tiempo de la distancia 11: " & dCost11)

        End Sub
        Public Function Tiempototal()
            SAM = tCost1 + tCost2 + tCost3 + tCost4 + tCost5 + tCost6 + tCost7 + tCost8 + tCost9 + tCost10 + tCost11
            Return SAM
        End Function
        Public Function dtCostura()
            dtotalCostura = dCost1 + dCost2 + dCost3 + dCost4 + dCost5 + dCost6 + dCost7 + dCost8 + dCost9 + dCost10 + dCost11
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            cantHilo = (dCost1 + dCost2 + dCost3 + dCost4 + dCost5 + dCost6 + dCost7 + dCost8 + dCost9 + dCost10 + dCost11) * 2 + (dCost1 + dCost2 + dCost3 + dCost4 + dCost5 + dCost6 + dCost7 + dCost8 + dCost9 + dCost10 + dCost11) * 2 * 0.05
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            costototal = (((dCost1 + dCost2 + dCost3 + dCost4 + dCost5 + dCost6 + dCost7 + dCost8 + dCost9 + dCost10 + dCost11) * 2 + (dCost1 + dCost2 + dCost3 + dCost4 + dCost5 + dCost6 + dCost7 + dCost8 + dCost9 + dCost10 + dCost11) * 2 * 0.05) * costohilo) + (tCost1 + tCost2 + tCost3 + tCost4 + tCost5 + tCost6 + tCost7 + tCost8 + tCost9 + tCost10 + tCost11) * costominuto
            Return costototal
        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New Playera()
        playera1.IngresarDatos()


        mhilonecesarios = playera1.cantidadHilo()
        tfabricacion = playera1.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera()

        Console.WriteLine(" ________Para este lote se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)


    End Sub
End Module
