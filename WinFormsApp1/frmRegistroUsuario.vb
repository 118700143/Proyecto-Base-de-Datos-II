Imports MySql.Data.MySqlClient

Public Class frmRegistroUsuario

    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim username As String = txtNuevoUsuario.Text.Trim()
        Dim password As String = txtNuevaContrasena.Text.Trim()

        ' Validaciones básicas
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del sub si los campos están vacíos
        End If

        Dim connectionString As String = "server=localhost;port=3306;database=brendan_MY_DB;uid=root;pwd=118700143;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Primero, verificar si el nombre de usuario ya existe
                Dim checkUserQuery As String = "SELECT COUNT(*) FROM usuarios WHERE username = @username"
                Using checkCommand As New MySqlCommand(checkUserQuery, connection)
                    checkCommand.Parameters.AddWithValue("@username", username)
                    Dim existingUsers As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If existingUsers > 0 Then
                        MessageBox.Show("El nombre de usuario '" & username & "' ya existe. Por favor, elija otro.", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return ' Salir si el usuario ya existe
                    End If
                End Using

                ' Si el usuario no existe, proceder con la inserción
                Dim insertQuery As String = "INSERT INTO usuarios (username, password) VALUES (@username, @password)"

                Using command As New MySqlCommand(insertQuery, connection)
                    ' Añadir parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password) ' ¡Recordatorio: en una app real, hashea las contraseñas!

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario '" & username & "' registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Opcional: Limpiar los campos después de un registro exitoso
                        txtNuevoUsuario.Clear()
                        txtNuevaContrasena.Clear()
                        txtNuevoUsuario.Focus() ' Poner el foco en el campo de usuario
                    Else
                        MessageBox.Show("No se pudo registrar el usuario. Inténtelo de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error de base de datos al registrar usuario: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error inesperado: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class