Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Form1
    Private conexion As New Conexion()
    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        frmCrearcuenta.Show()
        Me.Show()
    End Sub



    Public Class Usuario
        Public Property Nombre As String
        Public Property Contrasena As String

        Private Function HashearSHA256(texto As String) As String
            Using sha256 As SHA256 = sha256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
                Dim hash As Byte() = sha256.ComputeHash(bytes)
                Return BitConverter.ToString(hash).Replace("-", "").ToLower()
            End Using
        End Function

        Public Function Login() As Boolean
            Dim conexion As New Conexion()
            Dim conn As MySqlConnection = Nothing

            Try
                conn = conexion.Abrir()
                Dim query As String = "SELECT * FROM usuarios WHERE nombre = @nombre AND password = @password"
                Using command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@nombre", Nombre)
                    command.Parameters.AddWithValue("@password", HashearSHA256(Contrasena))

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Return True
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error en el login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexion.Cerrar()
            End Try

            Return False
        End Function
    End Class

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        Dim usuario As New Usuario()
        usuario.Nombre = txtNuevoUsuario.Text.Trim()
        usuario.Contrasena = txtNuevaContrasena.Text.Trim()

        If usuario.Login() Then
            MessageBox.Show("Inicio de sesión exitoso. Bienvenido " & usuario.Nombre, "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtNuevoUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNuevoUsuario.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
