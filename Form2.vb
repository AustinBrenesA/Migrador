Public Class Form2
    Dim conexion As Conexion = New Conexion()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar() 'conectarse a la base de datos
        Dim dt = conexion.cargarprovincia()
        Cmbprovincia.DataSource = dt
        Cmbprovincia.DisplayMember = "DESCRIPCION_PROVINCIA"
        Cmbprovincia.ValueMember = "CODIGO_PROVINCIA"
        Cmbprovincia.SelectedIndex = -1
    End Sub

    Private Sub Cmbprovincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmbprovincia.SelectionChangeCommitted
        Dim dt = conexion.cargarcanton(Cmbprovincia.SelectedValue.ToString)
        Cmbcanton.DataSource = dt
        Cmbcanton.DisplayMember = "DESCRIPCION_CANTON"
        Cmbcanton.ValueMember = "CODIGO_CANTON"
        Cmbdistrito.DataSource = Nothing
        Cmbcanton.SelectedIndex = 0
    End Sub



    Private Sub Cmbcanton_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmbcanton.SelectionChangeCommitted
        Dim dt = conexion.carga_distrito(Cmbcanton.SelectedValue.ToString(), Cmbprovincia.SelectedValue.ToString())
        Cmbdistrito.DataSource = dt
        Cmbdistrito.DisplayMember = "DESCRIPCION_DISTRITO"
        Cmbdistrito.ValueMember = "CODIGO_DISTRITO"
        Cmbdistrito.SelectedIndex = 0
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click

    End Sub
End Class