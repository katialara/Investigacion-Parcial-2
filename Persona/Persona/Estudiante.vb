Public Class Estudiante
    Inherits Persona 'clase estudiante va a heredar de persona

    'Declaración de atributos
    Private Matricula As String
    Private Carrera As String
    Private Curso As String
    Private Semestre As Integer

    'Declaración de métodos
    Public Property MatriculaE() As String
        Get
            Return Matricula
        End Get
        Set(value As String)
            Matricula = value
        End Set
    End Property

    Public Property CarreraE() As String
        Get
            Return Carrera
        End Get
        Set(value As String)
            Carrera = value
        End Set
    End Property

    Public Property CursoE() As String
        Get
            Return Curso
        End Get
        Set(value As String)
            Curso = value
        End Set
    End Property

    Public Property SemestreE() As Integer
        Get
            Return Semestre
        End Get
        Set(value As Integer)
            Semestre = value
        End Set
    End Property

    'Declaración de constructor
    Public Sub Estudiante(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal Edad1 As Integer, ByVal Matricula1 As String, Carrera1 As String, Curso1 As String, Semestre1 As Integer)
        'atributo = parametro
        NombreP = Nombre1
        ApPaternoP = ApPaterno1
        ApMaternoP = ApMaterno1
        EdadP = Edad1
        Matricula = Matricula1
        Carrera = Carrera1
        Curso = Curso1
        Semestre = Semestre1
    End Sub

    Public ReadOnly Property Info() As String 'mostrar información
        Get
            Dim Cadena As String
            Cadena = "Nombre:= " + NombreP() & vbCrLf + "Apellido Paterno:= " + ApPaternoP() & vbCrLf + "Apellido Materno:= " + ApMaternoP() & vbCrLf + "Edad:= " + EdadP().ToString & vbCrLf + "Matricula:= " + MatriculaE() & vbCrLf + "Carrera:=  " + CarreraE() & vbCrLf + "Curso:= " + CursoE() & vbCrLf + "Semestre:= " + SemestreE().ToString & vbCrLf
            Return Cadena
        End Get
    End Property

End Class
