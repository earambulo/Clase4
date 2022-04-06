Imports System.ComponentModel.DataAnnotations

Public Class Empleado
    <Required(ErrorMessage:="Debe ingresar su numero de documento")>
    <MaxLength(6, ErrorMessage:="Debe tener hasta 6 caracteres el numero de documento")>
    <Display(Name:="Nro. Documento")>
    Public Property NroDocumento() As String
    <Required(ErrorMessage:="Debe ingresar su nombre")>
    Public Property Nombre() As String
    <Required(ErrorMessage:="Debe ingresar su apellido")>
    Public Property Apellido() As String
    <Required(ErrorMessage:="Debe ingresar su dirección")>
    <Display(Name:="Dirección")>
    Public Property Direccion() As String
    <Required(ErrorMessage:="Debe ingresar su fecha de nacimiento")>
    <Display(Name:="Fecha de nacimiento")>
    Public Property FechaNacimiento() As Date
    <Required(ErrorMessage:="Debe ingresar su email")>
    Public Property Email() As String
    <Required(ErrorMessage:="Debe ingresar su salario")>
    <Range(1000000, 15000000, ErrorMessage:="El salario debe ser entre 1.000.000 a 15.000.000")>
    Public Property Salario() As Integer

End Class
