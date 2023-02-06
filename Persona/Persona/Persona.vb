Public Class Persona
    'Declaración de atributos
    'estoy actualizando desde visual studio 
    Private Nombre As String
    Private ApPaterno As String
    Private ApMaterno As String
    Private Edad As Integer

    'Declaración de métodos
    Public Property NombreP() As String
        Get  'obtiene los valores de los atributos
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property


    Public Property ApPaternoP() As String
        Get
            Return ApPaterno
        End Get
        Set(value As String)
            ApPaterno = value
        End Set
    End Property


    Public Property ApMaternoP() As String
        Get
            Return ApMaterno
        End Get
        Set(value As String)
            ApMaterno = value
        End Set
    End Property

    Public Property EdadP() As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property

    'Crear constructor, sirve para inicializar los atributos de la clase, recibe 4 parametros que están definidos en la clase
    Public Sub Persona(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal Edad1 As Integer)
        Nombre = Nombre1
        ApPaterno = ApPaterno1
        ApMaterno = ApMaterno1
        Edad = Edad1
    End Sub

    Public ReadOnly Property Info() As String
        Get
            Dim Cadena As String
            Cadena = "Nombre:= " + NombreP() + "Apellido Paterno:= " + ApPaternoP() + "Apellido Materno:= " + ApMaternoP() + "Edad:= " + EdadP().ToString
            Return Cadena
        End Get
    End Property

End Class
