Public Class ProfesorPTC
    Inherits Profesor
    Private HorasClase As Integer
    Private HorasGestion As Integer
    Private HorasInvestigacion As Integer
    Private HorasTutorias As Integer

    'Declaración de métodos
    Public Property HorasClasePr() As Integer
        Get
            Return HorasClase
        End Get
        Set(value As Integer)
            HorasClase = value
        End Set
    End Property

    Public Property HorasGestionPr() As Integer
        Get
            Return HorasGestion
        End Get
        Set(value As Integer)
            HorasGestion = value
        End Set
    End Property

    Public Property HorasInvestigacionPr() As Integer
        Get
            Return HorasInvestigacion
        End Get
        Set(value As Integer)
            HorasInvestigacion = value
        End Set
    End Property

    Public Property HorasTutoriasPr() As Integer
        Get
            Return HorasTutorias
        End Get
        Set(value As Integer)
            HorasTutorias = value
        End Set
    End Property

    Public Sub ProfesorPTC(ByVal Nombre1 As String, ByVal ApPaterno1 As String, ByVal ApMaterno1 As String, ByVal Edad1 As Integer, ByVal Expediente1 As Integer, ByVal Categoria1 As String, ByVal HorasClase1 As Integer, ByVal HorasGestion1 As Integer, ByVal HorasInvestigacion1 As Integer, ByVal HorasTutorias1 As Integer)
        'atributo = parametro
        NombreP = Nombre1
        ApPaternoP = ApPaterno1
        ApMaternoP = ApMaterno1
        EdadP = Edad1
        CategoriaPr = Categoria1
        ExpedientePr = Expediente1
        HorasClasePr = HorasClase1
        HorasGestionPr = HorasGestion1
        HorasInvestigacionPr = HorasInvestigacion1
        HorasTutoriasPr = HorasTutorias1
    End Sub

    Public ReadOnly Property Info() As String 'mostrar información
        Get
            Dim Cadena As String
            Cadena = "Nombre:= " + NombreP() & vbCrLf + "Apellido Paterno:= " + ApPaternoP() & vbCrLf + "Apellido Materno:= " + ApMaternoP() & vbCrLf + "Edad:= " + EdadP().ToString & vbCrLf + "Expediente:= " + ExpedientePr().ToString & vbCrLf + "Categoría:=  " + CategoriaPr() & vbCrLf + "Horas Clase:= " + HorasClasePr().ToString & vbCrLf + "Horas Gestión:= " + HorasGestionPr().ToString & vbCrLf + "Horas Investigación:= " + HorasInvestigacionPr().ToString & vbCrLf + "Horas Tutorías:= " + HorasTutoriasPr().ToString & vbCrLf
            Return Cadena
        End Get

    End Property
End Class
