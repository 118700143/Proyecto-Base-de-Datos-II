<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearcuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearcuenta))
        GroupBox1 = New GroupBox()
        cbotipousuariocrearcuenta = New ComboBox()
        txtcorreocrearcuenta = New TextBox()
        Label6 = New Label()
        txtnombrecrearcuenta = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        txtcontrasenacrearcuenta = New TextBox()
        Label4 = New Label()
        btnguardarcrearcuenta = New Button()
        btnvolver = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(btnvolver)
        GroupBox1.Controls.Add(cbotipousuariocrearcuenta)
        GroupBox1.Controls.Add(txtcorreocrearcuenta)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtnombrecrearcuenta)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtcontrasenacrearcuenta)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnguardarcrearcuenta)
        GroupBox1.Location = New Point(38, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(652, 365)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "INGRESAR"
        ' 
        ' cbotipousuariocrearcuenta
        ' 
        cbotipousuariocrearcuenta.FormattingEnabled = True
        cbotipousuariocrearcuenta.Items.AddRange(New Object() {"Admin", "Soporte ", "Cliente"})
        cbotipousuariocrearcuenta.Location = New Point(275, 108)
        cbotipousuariocrearcuenta.Name = "cbotipousuariocrearcuenta"
        cbotipousuariocrearcuenta.Size = New Size(159, 23)
        cbotipousuariocrearcuenta.TabIndex = 13
        ' 
        ' txtcorreocrearcuenta
        ' 
        txtcorreocrearcuenta.Location = New Point(275, 194)
        txtcorreocrearcuenta.Name = "txtcorreocrearcuenta"
        txtcorreocrearcuenta.Size = New Size(159, 23)
        txtcorreocrearcuenta.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(101, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 11
        Label6.Text = "Correo"
        ' 
        ' txtnombrecrearcuenta
        ' 
        txtnombrecrearcuenta.Location = New Point(275, 68)
        txtnombrecrearcuenta.Name = "txtnombrecrearcuenta"
        txtnombrecrearcuenta.Size = New Size(159, 23)
        txtnombrecrearcuenta.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(101, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 9
        Label5.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 8
        Label3.Text = "Contrasena"
        ' 
        ' txtcontrasenacrearcuenta
        ' 
        txtcontrasenacrearcuenta.Location = New Point(275, 154)
        txtcontrasenacrearcuenta.Name = "txtcontrasenacrearcuenta"
        txtcontrasenacrearcuenta.Size = New Size(159, 23)
        txtcontrasenacrearcuenta.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 5
        Label4.Text = "Tipo_Usuario"
        ' 
        ' btnguardarcrearcuenta
        ' 
        btnguardarcrearcuenta.Location = New Point(448, 276)
        btnguardarcrearcuenta.Name = "btnguardarcrearcuenta"
        btnguardarcrearcuenta.Size = New Size(168, 76)
        btnguardarcrearcuenta.TabIndex = 0
        btnguardarcrearcuenta.Text = "Crear cuenta"
        btnguardarcrearcuenta.UseVisualStyleBackColor = True
        ' 
        ' btnvolver
        ' 
        btnvolver.Location = New Point(65, 284)
        btnvolver.Name = "btnvolver"
        btnvolver.Size = New Size(123, 61)
        btnvolver.TabIndex = 14
        btnvolver.Text = "Volver"
        btnvolver.UseVisualStyleBackColor = True
        ' 
        ' frmCrearcuenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(734, 410)
        Controls.Add(GroupBox1)
        Name = "frmCrearcuenta"
        Text = "frmCrearcuenta"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontrasenacrearcuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnguardarcrearcuenta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnombrecrearcuenta As TextBox
    Friend WithEvents txtcorreocrearcuenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbotipousuariocrearcuenta As ComboBox
    Friend WithEvents btnvolver As Button
End Class
