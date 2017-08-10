Imports Jaula_de_Loro


Module LoroTest

    Sub Main()
        Dim loro As New Loro()
        loro.FechaNacimiento = #2015/01/03#
        Console.WriteLine("La edad del loro es: " & loro.Edad)
        loro.Nombre = "Pepe"
        Dim frase As String = "Papita "
        loro.Escuchar(frase)
        frase = "pal loro "
        loro.Escuchar(frase)
        frase = "Pepe"
        loro.Escuchar(frase)
        Console.WriteLine(loro.Hablar)
        Console.WriteLine(loro.Hablar)
        Console.WriteLine(loro.Hablar)
        Console.WriteLine(loro.Hablar)
        Console.WriteLine("El nombre del loro es: " & loro.Nombre)
        Console.ReadKey()
    End Sub

End Module
