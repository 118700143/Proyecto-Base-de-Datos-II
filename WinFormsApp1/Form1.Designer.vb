<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        txtNuevaContrasena = New TextBox()
        txtNuevoUsuario = New TextBox()
        Label1 = New Label()
        btnRegistrarUsuario = New Button()
        btniniciar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNuevaContrasena)
        GroupBox1.Controls.Add(txtNuevoUsuario)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnRegistrarUsuario)
        GroupBox1.Controls.Add(btniniciar)
        GroupBox1.Location = New Point(38, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(646, 372)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 8
        Label2.Text = "contrasena"
        ' 
        ' txtNuevaContrasena
        ' 
        txtNuevaContrasena.BackColor = SystemColors.InactiveCaption
        txtNuevaContrasena.Location = New Point(275, 151)
        txtNuevaContrasena.Name = "txtNuevaContrasena"
        txtNuevaContrasena.Size = New Size(157, 21)
        txtNuevaContrasena.TabIndex = 7
        txtNuevaContrasena.TextAlign = HorizontalAlignment.Right
        txtNuevaContrasena.UseSystemPasswordChar = True
        ' 
        ' txtNuevoUsuario
        ' 
        txtNuevoUsuario.BackColor = SystemColors.InactiveCaption
        txtNuevoUsuario.Location = New Point(273, 81)
        txtNuevoUsuario.Name = "txtNuevoUsuario"
        txtNuevoUsuario.Size = New Size(159, 21)
        txtNuevoUsuario.TabIndex = 6
        txtNuevoUsuario.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' btnRegistrarUsuario
        ' 
        btnRegistrarUsuario.BackColor = SystemColors.ActiveCaption
        btnRegistrarUsuario.Location = New Point(29, 279)
        btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        btnRegistrarUsuario.Size = New Size(185, 80)
        btnRegistrarUsuario.TabIndex = 1
        btnRegistrarUsuario.Text = "RegistrarUsuario"
        btnRegistrarUsuario.UseVisualStyleBackColor = False
        ' 
        ' btniniciar
        ' 
        btniniciar.BackColor = SystemColors.ActiveCaption
        btniniciar.Location = New Point(448, 276)
        btniniciar.Name = "btniniciar"
        btniniciar.Size = New Size(168, 76)
        btniniciar.TabIndex = 0
        btniniciar.Text = "iniciar seccion"
        btniniciar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.Chocolate
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(732, 413)
        Controls.Add(GroupBox1)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        StartPosition = FormStartPosition.Manual
        Text = "Form1"
        WindowState = FormWindowState.Minimized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegistrarUsuario As Button
    Friend WithEvents btniniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNuevoUsuario As TextBox
    Friend WithEvents txtNuevaContrasena As TextBox
    Friend WithEvents Label2 As Label

End Class
