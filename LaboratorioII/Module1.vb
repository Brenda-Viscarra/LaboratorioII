Module Module1

    Sub Main()
        EjercicioA()
        EjercicioB()

        Console.ReadKey()
    End Sub

    Sub EjercicioA()
        Console.WriteLine("....::::EJERCICIO A::::....")
        Dim costoArticuloV As Double
        Dim dineroCliente As Double

        Console.Write("Ingrese el costo del articulo: $")
        costoArticuloV = Double.Parse(Console.ReadLine())
        Console.Write("Ingrese la cantidad de dinero a pagar: $")
        dineroCliente = Double.Parse(Console.ReadLine())

        If dineroCliente > costoArticuloV Then
            Dim cambio As Double = dineroCliente - costoArticuloV
            Console.WriteLine("El producto cuesta: $" & costoArticuloV & " entonces, su cambio es: $" & cambio)
            Console.WriteLine("PRODUCTO ENTREGADO")
        ElseIf dineroCliente = costoArticuloV Then
            Console.WriteLine("Usted entregó exactamente lo que vale el producto... Dinero entregado: $" & dineroCliente & " precio: $" & costoArticuloV)
            Console.WriteLine("PRODUCTO ENTREGADO")
        ElseIf dineroCliente < costoArticuloV Then
            Dim dineroFaltante As Double = costoArticuloV - dineroCliente
            Console.WriteLine("Le faltan $" & dineroFaltante & " para comprar el articulo")
            If dineroFaltante > 0 Then
                Console.WriteLine("Querido cliente, usted no posee suficiente dinero para efectuar la compra")
                Console.WriteLine("...:::VUELVA PRONTO POR EL PRODUCTO QUE DESEA:::...")
            End If
        End If
    End Sub

    Sub EjercicioB()
        Console.WriteLine()
        Console.WriteLine("....::::EJERCICIO B::::....")
        Dim total As Double
        Dim montoCompra As Double

        Console.WriteLine("Ingrese los montos de las compras del cliente")
        Console.Write("Monto de compra: ")
        montoCompra = Double.Parse(Console.ReadLine())

        If montoCompra < 0 Then
            Console.WriteLine("Ingrese un monto válido.")
        ElseIf montoCompra > 1000 Then
            total = montoCompra - (montoCompra * 0.1)
        ElseIf montoCompra > 500 Then
            total = montoCompra - (montoCompra * 0.05)
        Else
            total = montoCompra
        End If

        Console.WriteLine("Total a pagar con descuentos aplicados: $" & total.ToString("0.00"))
    End Sub
End Module
