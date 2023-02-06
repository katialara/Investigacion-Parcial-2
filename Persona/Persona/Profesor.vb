Public Class Profesor
    Inherits Persona
    'Atributos
    Private Expediente As Integer
    Private Categoria As String

    Public Property ExpedientePr() As Integer
        Get
            Return Expediente
        End Get
        Set(value As Integer)
            Expediente = value
        End Set
    End Property

    Public Property CategoriaPr() As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property

    'Declaración de constructor
    Public Sub Profesor(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal Edad1 As Integer, ByVal Expediente1 As Integer, ByVal Categoria1 As String)
        'atributo = parametro
        NombreP = Nombre1
        ApPaternoP = ApPaterno1
        ApMaternoP = ApMaterno1
        EdadP = Edad1
        ExpedientePr = Expediente1
        CategoriaPr = Categoria1
    End Sub

    Public ReadOnly Property Info() As String 'mostrar información
        Get
            Dim Cadena As String
            Cadena = "Nombre:= " + NombreP() & vbCrLf + "Apellido Paterno:= " + ApPaternoP() & vbCrLf + "Apellido Materno:= " + ApMaternoP() & vbCrLf + "Edad:= " + EdadP().ToString & vbCrLf + "Expediente:= " + ExpedientePr().ToString & vbCrLf + "Categoría:=  " + CategoriaPr() & vbCrLf
            Return Cadena
        End Get

    End Property
End Class
