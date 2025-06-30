<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnVolver = New Button()
        btnRegistrarUsuario = New Button()
        GroupBox1 = New GroupBox()
        txtNuevaContrasena = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtNuevoUsuario = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVolver
        ' 
        btnVolver.Location = New Point(605, 352)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(113, 57)
        btnVolver.TabIndex = 0
        btnVolver.Text = "Button1"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarUsuario
        ' 
        btnRegistrarUsuario.Location = New Point(49, 352)
        btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        btnRegistrarUsuario.Size = New Size(108, 57)
        btnRegistrarUsuario.TabIndex = 1
        btnRegistrarUsuario.Text = "Button2"
        btnRegistrarUsuario.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtNuevaContrasena)
        GroupBox1.Controls.Add(txtNuevoUsuario)
        GroupBox1.Controls.Add(btnRegistrarUsuario)
        GroupBox1.Controls.Add(btnVolver)
        GroupBox1.Location = New Point(16, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(762, 421)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' txtNuevaContrasena
        ' 
        txtNuevaContrasena.Location = New Point(300, 208)
        txtNuevaContrasena.Name = "txtNuevaContrasena"
        txtNuevaContrasena.Size = New Size(157, 23)
        txtNuevaContrasena.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 5
        Label2.Text = "contrasena"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(171, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 4
        Label1.Text = "Usuario"
        ' 
        ' txtNuevoUsuario
        ' 
        txtNuevoUsuario.Location = New Point(298, 168)
        txtNuevoUsuario.Name = "txtNuevoUsuario"
        txtNuevoUsuario.Size = New Size(159, 23)
        txtNuevoUsuario.TabIndex = 2
        ' 
        ' frmRegistroUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "frmRegistroUsuario"
        Text = "frmRegistroUsuario"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnRegistrarUsuario As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNuevaContrasena As TextBox
    Friend WithEvents txtNuevoUsuario As TextBox
End Class
