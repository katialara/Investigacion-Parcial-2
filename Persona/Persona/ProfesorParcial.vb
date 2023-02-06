Public Class ProfesorParcial
    Inherits Profesor
    Private HorasClase As Integer
    Private HorasAsignadas As Integer

    Public Property HorasClasePr() As Integer
        Get
            Return HorasClase
        End Get
        Set(value As Integer)
            HorasClase = value
        End Set
    End Property

    Public Property HorasAsignadasPr() As Integer
        Get
            Return HorasAsignadas
        End Get
        Set(value As Integer)
            HorasAsignadas = value
        End Set
    End Property

    Public Sub ProfesorParcial(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal Edad1 As Integer, ByVal Expediente1 As Integer, ByVal Categoria1 As String, ByVal HorasClase1 As Integer, ByVal HorasAsignadas1 As Integer)
        NombreP = Nombre1
        ApPaternoP = ApPaterno1
        ApMaternoP = ApMaterno1
        EdadP = Edad1
        ExpedientePr = Expediente1
        CategoriaPr = Categoria1
        HorasClasePr = HorasClase1
        HorasAsignadasPr = HorasAsignadas1
    End Sub

    Public ReadOnly Property Info() As String 'mostrar información
        Get
            Dim Cadena As String
            Cadena = "Nombre:= " + NombreP() & vbCrLf + "Apellido Paterno:= " + ApPaternoP() & vbCrLf + "Apellido Materno:= " + ApMaternoP() & vbCrLf + "Edad:= " + EdadP().ToString & vbCrLf + "Expediente:= " + ExpedientePr().ToString & vbCrLf + "Categoría:=  " + CategoriaPr() & vbCrLf + "Horas Clase:= " + HorasClasePr().ToString & vbCrLf + "Horas asignadas:= " + HorasAsignadasPr().ToString & vbCrLf
            Return Cadena
        End Get

    End Property

End Class
