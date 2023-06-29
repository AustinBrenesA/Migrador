<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Txtruta = New System.Windows.Forms.TextBox()
        Me.Botcarga_dvt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtruta
        '
        Me.Txtruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtruta.Location = New System.Drawing.Point(399, 66)
        Me.Txtruta.Name = "Txtruta"
        Me.Txtruta.Size = New System.Drawing.Size(623, 32)
        Me.Txtruta.TabIndex = 0
        '
        'Botcarga_dvt
        '
        Me.Botcarga_dvt.Location = New System.Drawing.Point(104, 36)
        Me.Botcarga_dvt.Name = "Botcarga_dvt"
        Me.Botcarga_dvt.Size = New System.Drawing.Size(230, 97)
        Me.Botcarga_dvt.TabIndex = 1
        Me.Botcarga_dvt.Text = "CARGA DIVISION TERRITORIAL EN BD"
        Me.Botcarga_dvt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1668, 651)
        Me.Controls.Add(Me.Botcarga_dvt)
        Me.Controls.Add(Me.Txtruta)
        Me.Name = "Form1"
        Me.Text = "Migrador de datos Division Territorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtruta As TextBox
    Friend WithEvents Botcarga_dvt As Button
End Class
