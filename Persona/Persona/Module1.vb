Module Module1

    Sub Main()
        Dim Estudiante1 As Estudiante
        Estudiante1 = New Estudiante()

        'el objeto estudiante1 va a tener acceso a todos los parametros
        'el constructor estudiante recibe todos los parametros
        Estudiante1.Estudiante("Santiago", "Lara", "De Los Santos", 29, "18249243", "ISC", "Programación III", 6)
        Console.WriteLine("OBJETO TIPO ESTUDIANTE:")
        Console.WriteLine(Estudiante1.Info)

        Dim Profesor1 As Profesor
        Profesor1 = New Profesor()
        Profesor1.Profesor("Rodolfo", "Muñoz", "Cantú", 30, 2354, "Series de Fourier")
        Console.WriteLine("OBJETO TIPO PROFESOR:")
        Console.WriteLine(Profesor1.Info)

        Dim ProfesorParcial1 As ProfesorParcial
        ProfesorParcial1 = New ProfesorParcial()
        ProfesorParcial1.ProfesorParcial("Rosario", "Luna", "Martínez", 39, 1245, "Estructura de datos II", 50, 30)
        Console.WriteLine("OBJETO TIPO PROFESOR TIEMPO PARCIAL:")
        Console.WriteLine(ProfesorParcial1.Info)

        Dim ProfesorPTC1 As ProfesorPTC
        ProfesorPTC1 = New ProfesorPTC()
        ProfesorPTC1.ProfesorPTC("Franco", "Genel", "Castro", 39, 1245, "Inglés V", 50, 35, 25, 20)
        Console.WriteLine("OBJETO TIPO PROFESOR TIEMPO COMPLETO:")
        Console.WriteLine(ProfesorPTC1.Info)

        Console.ReadKey()
    End Sub

End Module
