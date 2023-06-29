<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Cmbtipoid = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.Lblnumeroid = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblapellido1 = New System.Windows.Forms.Label()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Tztnombre = New System.Windows.Forms.TextBox()
        Me.Txtapellido1 = New System.Windows.Forms.TextBox()
        Me.Txtapellido2 = New System.Windows.Forms.TextBox()
        Me.Grbdatos_personales = New System.Windows.Forms.GroupBox()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Btnconsultar = New System.Windows.Forms.Button()
        Me.Cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Cmbcanton = New System.Windows.Forms.ComboBox()
        Me.Cmbdistrito = New System.Windows.Forms.ComboBox()
        Me.Btnmodificar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Lblprovincia = New System.Windows.Forms.Label()
        Me.Lblcanton = New System.Windows.Forms.Label()
        Me.Lbldistrito = New System.Windows.Forms.Label()
        Me.Lbltelefono = New System.Windows.Forms.Label()
        Me.Lblcorreo = New System.Windows.Forms.Label()
        Me.Lestado = New System.Windows.Forms.Label()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Grbdatos_personales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmbtipoid
        '
        Me.Cmbtipoid.FormattingEnabled = True
        Me.Cmbtipoid.Location = New System.Drawing.Point(44, 61)
        Me.Cmbtipoid.Name = "Cmbtipoid"
        Me.Cmbtipoid.Size = New System.Drawing.Size(157, 28)
        Me.Cmbtipoid.TabIndex = 0
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(384, 61)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(585, 26)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Location = New System.Drawing.Point(40, 25)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(205, 20)
        Me.Lblid.TabIndex = 2
        Me.Lblid.Text = "TIPO DE IDENTIFICACION"
        '
        'Lblnumeroid
        '
        Me.Lblnumeroid.AutoSize = True
        Me.Lblnumeroid.Location = New System.Drawing.Point(487, 25)
        Me.Lblnumeroid.Name = "Lblnumeroid"
        Me.Lblnumeroid.Size = New System.Drawing.Size(240, 20)
        Me.Lblnumeroid.TabIndex = 3
        Me.Lblnumeroid.Text = "NUMERO DE IDENTIFICACION"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1232, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(448, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(40, 131)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(79, 20)
        Me.Lblnombre.TabIndex = 5
        Me.Lblnombre.Text = "NOMBRE"
        '
        'Lblapellido1
        '
        Me.Lblapellido1.AutoSize = True
        Me.Lblapellido1.Location = New System.Drawing.Point(533, 131)
        Me.Lblapellido1.Name = "Lblapellido1"
        Me.Lblapellido1.Size = New System.Drawing.Size(155, 20)
        Me.Lblapellido1.TabIndex = 6
        Me.Lblapellido1.Text = "PRIMER APELLIDO"
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(1038, 131)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(174, 20)
        Me.Lblsegundo_apellido.TabIndex = 7
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Tztnombre
        '
        Me.Tztnombre.Location = New System.Drawing.Point(12, 190)
        Me.Tztnombre.Name = "Tztnombre"
        Me.Tztnombre.Size = New System.Drawing.Size(448, 26)
        Me.Tztnombre.TabIndex = 8
        '
        'Txtapellido1
        '
        Me.Txtapellido1.Location = New System.Drawing.Point(521, 190)
        Me.Txtapellido1.Name = "Txtapellido1"
        Me.Txtapellido1.Size = New System.Drawing.Size(448, 26)
        Me.Txtapellido1.TabIndex = 9
        '
        'Txtapellido2
        '
        Me.Txtapellido2.Location = New System.Drawing.Point(1019, 190)
        Me.Txtapellido2.Name = "Txtapellido2"
        Me.Txtapellido2.Size = New System.Drawing.Size(409, 26)
        Me.Txtapellido2.TabIndex = 10
        '
        'Grbdatos_personales
        '
        Me.Grbdatos_personales.Controls.Add(Me.Btnguardar)
        Me.Grbdatos_personales.Controls.Add(Me.Txtapellido2)
        Me.Grbdatos_personales.Controls.Add(Me.Txtapellido1)
        Me.Grbdatos_personales.Controls.Add(Me.Tztnombre)
        Me.Grbdatos_personales.Controls.Add(Me.Lblsegundo_apellido)
        Me.Grbdatos_personales.Controls.Add(Me.Lblapellido1)
        Me.Grbdatos_personales.Controls.Add(Me.Lblnombre)
        Me.Grbdatos_personales.Controls.Add(Me.Lblnumeroid)
        Me.Grbdatos_personales.Controls.Add(Me.Lblid)
        Me.Grbdatos_personales.Controls.Add(Me.MaskedTextBox1)
        Me.Grbdatos_personales.Controls.Add(Me.Cmbtipoid)
        Me.Grbdatos_personales.Controls.Add(Me.Btnconsultar)
        Me.Grbdatos_personales.Location = New System.Drawing.Point(0, 12)
        Me.Grbdatos_personales.Name = "Grbdatos_personales"
        Me.Grbdatos_personales.Size = New System.Drawing.Size(1703, 253)
        Me.Grbdatos_personales.TabIndex = 11
        Me.Grbdatos_personales.TabStop = False
        Me.Grbdatos_personales.Text = "DATOS PERSONALES"
        '
        'Btnguardar
        '
        Me.Btnguardar.Location = New System.Drawing.Point(1544, 61)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(153, 80)
        Me.Btnguardar.TabIndex = 11
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Btnconsultar
        '
        Me.Btnconsultar.Location = New System.Drawing.Point(1550, 163)
        Me.Btnconsultar.Name = "Btnconsultar"
        Me.Btnconsultar.Size = New System.Drawing.Size(153, 80)
        Me.Btnconsultar.TabIndex = 15
        Me.Btnconsultar.Text = "Consultar"
        Me.Btnconsultar.UseVisualStyleBackColor = True
        '
        'Cmbprovincia
        '
        Me.Cmbprovincia.FormattingEnabled = True
        Me.Cmbprovincia.Location = New System.Drawing.Point(44, 349)
        Me.Cmbprovincia.Name = "Cmbprovincia"
        Me.Cmbprovincia.Size = New System.Drawing.Size(265, 28)
        Me.Cmbprovincia.TabIndex = 12
        '
        'Cmbcanton
        '
        Me.Cmbcanton.FormattingEnabled = True
        Me.Cmbcanton.Location = New System.Drawing.Point(446, 349)
        Me.Cmbcanton.Name = "Cmbcanton"
        Me.Cmbcanton.Size = New System.Drawing.Size(313, 28)
        Me.Cmbcanton.TabIndex = 13
        '
        'Cmbdistrito
        '
        Me.Cmbdistrito.FormattingEnabled = True
        Me.Cmbdistrito.Location = New System.Drawing.Point(858, 349)
        Me.Cmbdistrito.Name = "Cmbdistrito"
        Me.Cmbdistrito.Size = New System.Drawing.Size(313, 28)
        Me.Cmbdistrito.TabIndex = 14
        '
        'Btnmodificar
        '
        Me.Btnmodificar.Location = New System.Drawing.Point(1550, 271)
        Me.Btnmodificar.Name = "Btnmodificar"
        Me.Btnmodificar.Size = New System.Drawing.Size(153, 80)
        Me.Btnmodificar.TabIndex = 16
        Me.Btnmodificar.Text = "Modificar"
        Me.Btnmodificar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(1550, 367)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(153, 80)
        Me.Btnlimpiar.TabIndex = 17
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Lblprovincia
        '
        Me.Lblprovincia.AutoSize = True
        Me.Lblprovincia.Location = New System.Drawing.Point(87, 302)
        Me.Lblprovincia.Name = "Lblprovincia"
        Me.Lblprovincia.Size = New System.Drawing.Size(97, 20)
        Me.Lblprovincia.TabIndex = 18
        Me.Lblprovincia.Text = "PROVINCIA"
        '
        'Lblcanton
        '
        Me.Lblcanton.AutoSize = True
        Me.Lblcanton.Location = New System.Drawing.Point(505, 302)
        Me.Lblcanton.Name = "Lblcanton"
        Me.Lblcanton.Size = New System.Drawing.Size(74, 20)
        Me.Lblcanton.TabIndex = 19
        Me.Lblcanton.Text = "CANTON"
        '
        'Lbldistrito
        '
        Me.Lbldistrito.AutoSize = True
        Me.Lbldistrito.Location = New System.Drawing.Point(943, 302)
        Me.Lbldistrito.Name = "Lbldistrito"
        Me.Lbldistrito.Size = New System.Drawing.Size(84, 20)
        Me.Lbldistrito.TabIndex = 20
        Me.Lbldistrito.Text = "DISTRITO"
        '
        'Lbltelefono
        '
        Me.Lbltelefono.AutoSize = True
        Me.Lbltelefono.Location = New System.Drawing.Point(87, 457)
        Me.Lbltelefono.Name = "Lbltelefono"
        Me.Lbltelefono.Size = New System.Drawing.Size(148, 20)
        Me.Lbltelefono.TabIndex = 21
        Me.Lbltelefono.Text = "TELEFONO MOVIL"
        '
        'Lblcorreo
        '
        Me.Lblcorreo.AutoSize = True
        Me.Lblcorreo.Location = New System.Drawing.Point(505, 457)
        Me.Lblcorreo.Name = "Lblcorreo"
        Me.Lblcorreo.Size = New System.Drawing.Size(79, 20)
        Me.Lblcorreo.TabIndex = 22
        Me.Lblcorreo.Text = "CORREO"
        '
        'Lestado
        '
        Me.Lestado.AutoSize = True
        Me.Lestado.Location = New System.Drawing.Point(1092, 442)
        Me.Lestado.Name = "Lestado"
        Me.Lestado.Size = New System.Drawing.Size(120, 20)
        Me.Lestado.TabIndex = 23
        Me.Lestado.Text = "ESTADO CIVIL"
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(87, 558)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(99, 20)
        Me.Lbldireccion.TabIndex = 24
        Me.Lbldireccion.Text = "DIRECCION"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(1051, 488)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(265, 28)
        Me.ComboBox4.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(44, 490)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(297, 26)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(397, 492)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(561, 51)
        Me.TextBox3.TabIndex = 27
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Location = New System.Drawing.Point(61, 608)
        Me.Txtdireccion.MaxLength = 200
        Me.Txtdireccion.Multiline = True
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(1387, 71)
        Me.Txtdireccion.TabIndex = 28
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(1550, 461)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(153, 80)
        Me.Btnsalir.TabIndex = 29
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1735, 717)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Txtdireccion)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.Lestado)
        Me.Controls.Add(Me.Lblcorreo)
        Me.Controls.Add(Me.Lbltelefono)
        Me.Controls.Add(Me.Lbldistrito)
        Me.Controls.Add(Me.Lblcanton)
        Me.Controls.Add(Me.Lblprovincia)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btnmodificar)
        Me.Controls.Add(Me.Cmbdistrito)
        Me.Controls.Add(Me.Cmbcanton)
        Me.Controls.Add(Me.Cmbprovincia)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Grbdatos_personales)
        Me.Name = "Form2"
        Me.Text = "CAPTURA INFORMACION PERSONAL Y SITUACIONAL DE LOS CIUDADANOS"
        Me.Grbdatos_personales.ResumeLayout(False)
        Me.Grbdatos_personales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmbtipoid As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Lblid As Label
    Friend WithEvents Lblnumeroid As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Lblapellido1 As Label
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Tztnombre As TextBox
    Friend WithEvents Txtapellido1 As TextBox
    Friend WithEvents Txtapellido2 As TextBox
    Friend WithEvents Grbdatos_personales As GroupBox
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Btnconsultar As Button
    Friend WithEvents Cmbprovincia As ComboBox
    Friend WithEvents Cmbcanton As ComboBox
    Friend WithEvents Cmbdistrito As ComboBox
    Friend WithEvents Btnmodificar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Lblprovincia As Label
    Friend WithEvents Lblcanton As Label
    Friend WithEvents Lbldistrito As Label
    Friend WithEvents Lbltelefono As Label
    Friend WithEvents Lblcorreo As Label
    Friend WithEvents Lestado As Label
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Btnsalir As Button
End Class
