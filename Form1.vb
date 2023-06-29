Public Class Form1
    Dim conexion As Conexion = New Conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.conectar()
    End Sub

    Private Sub Botcarga_dvt_Click(sender As Object, e As EventArgs) Handles Botcarga_dvt.Click

        If Txtruta.Text.Trim() = "" Then
            MessageBox.Show("Favor ingresar ruta de archivo")
            Return
        Else
            'Regla: Si hay datos no borre las tablas ni cargue el archivo y despliegue un mensaje que indique
            ' Que tablas ya fueron cargadas
            conexion.contar_filas()
            If f = 1 Then
                MsgBox("HAY REGISTROS EN LA BASE DE DATOS")

                If MessageBox.Show("DESEA BORRAR LAS TABLAS Y CARGAR NUEVAMENTE LOS DATOS?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    conexion.borratablas()
                    conexion.cargarchivo(Txtruta.Text.Trim())
                End If
            Else
                MsgBox("NO HAY REGISTROS EN LA BASE DE DATOS")
                conexion.cargarchivo(Txtruta.Text.Trim())
            End If
        End If
    End Sub
End Class
