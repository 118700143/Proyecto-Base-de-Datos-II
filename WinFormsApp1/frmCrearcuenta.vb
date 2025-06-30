Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class frmCrearCuenta

    Private conexion As New Conexion()
    Private Function HashPassword(password As String) As String
        If String.IsNullOrEmpty(password) Then
            Throw New ArgumentException("La contraseña no puede estar vacía.", NameOf(password))
        End If

        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
    Private Function HashearSHA256(texto As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub btnguardarcrearcuenta_Click(sender As Object, e As EventArgs) Handles btnguardarcrearcuenta.Click
        Dim nombre As String = txtnombrecrearcuenta.Text.Trim()
        Dim passwordOriginal As String = txtcontrasenacrearcuenta.Text.Trim()
        Dim password As String = HashearSHA256(passwordOriginal)
        Dim correo As String = txtcorreocrearcuenta.Text.Trim()
        Dim tipoUsuario As String = cbotipousuariocrearcuenta.SelectedItem?.ToString()

        If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(passwordOriginal) Then
            MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(tipoUsuario) Then
            MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn = conexion.Abrir()
                Dim insertQuery As String = "INSERT INTO usuarios (nombre, correo, password, tipo_usuario) VALUES (@nombre, @correo, @password, @tipo_usuario)"
                Using command As New MySqlCommand(insertQuery, conn)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@tipo_usuario", tipoUsuario)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario '" & nombre & "' registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtnombrecrearcuenta.Clear()
                        txtcontrasenacrearcuenta.Clear()
                        txtcorreocrearcuenta.Clear()
                        txtnombrecrearcuenta.Focus()
                    Else
                        MessageBox.Show("No se pudo registrar el usuario. Inténtelo de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error de base de datos al registrar usuario: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Form1.Hide()
        Me.Hide()
    End Sub
End Class