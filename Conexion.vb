Imports System.Data.SqlClient
Imports System.IO
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data source=DESKTOP-HPMS3LF;Initial Catalog=DIVISION_TERRITORIAL;Trusted_connection=Yes")
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder
    Dim idprovincia, idcanton As String
    Dim contprovincia As Integer = 1
    Dim contcanton As Integer = 1
    Dim contdistrito As Integer = 1
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONEXION EXITOSA")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            conexion.close()
        End Try
    End Sub

    Public Sub cargarchivo(ByVal ruta As String)
        'vamos a leer el archivo de texto
        Using myreader As New FileIO.TextFieldParser(ruta)
            myreader.TextFieldType = FileIO.FieldType.Delimited
            myreader.SetDelimiters(",")
            Dim currentrow As String()
            While Not myreader.EndOfData
                Try
                    currentrow = myreader.ReadFields()
                    insertardatos(currentrow(0), currentrow(1), currentrow(2), currentrow(3))
                Catch ex As Exception
                    MessageBox.Show("Error:" + ex.ToString)
                Finally
                    conexion.Close()
                End Try
            End While
            MessageBox.Show("Archivo se cargo correctamente en la base de datos, &Total de Registros Cargados" & d)
        End Using
    End Sub
    Public Sub borratablas()
        Try
            Borrar("delete from distrito")
            Borrar("delete from canton")
            Borrar("delete from provincia")
            MsgBox("Datos Borrados")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub insertardatos(ByVal id As String, ByVal provincia As String, ByVal canton As String, ByVal distrito As String)
        Dim a, b, c As Integer
        'id ='101001
        a = Mid(id, 1, 1)
        'a=1
        b = Mid(id, 2, 2)
        'b=01
        c = Mid(id, 4, 3)
        'c =001
        contprovincia = a

        'Insertando provincia
        consultar("SELECT * FROM PROVINCIA WHERE DESCRIPCION_PROVINCIA='" + provincia + "'", "PROVINCIA")
        If ds.Tables("PROVINCIA").Rows.Count = 0 Then
            'insertar(insert)
            insertar("INSERT INTO PROVINCIA VALUES(" + contprovincia.ToString() + ",'" + provincia + "')")
            idprovincia = a
        Else
            idprovincia = ds.Tables("PROVINCIA").Rows(0).Item(0).ToString()
            idprovincia = a
        End If

        'insertando el canton   

        consultar("SELECT * FROM CANTON WHERE CODIGO_PROVINCIA=" + idprovincia.ToString() + "and descripcion_canton= '" + canton + "'", "CANTON")
        If ds.Tables("CANTON").Rows.Count = 0 Then
            contcanton = b
            insertar("INSERT INTO CANTON VALUES(" + idprovincia + ",'" + contcanton.ToString() + "','" + canton + "')")
            idcanton = b
        Else
            idcanton = ds.Tables("CANTON").Rows(0).Item(0).ToString()
            idcanton = b
        End If

        consultar("SELECT * FROM DISTRITO WHERE CODIGO_PROVINCIA=" + idprovincia.ToString() + "AND CODIGO_CANTON=" + idcanton.ToString() + " AND DESCRIPCION_DISTRITO='" + distrito + "'", "DISTRITO")
        If ds.Tables("DISTRITO").Rows.Count = 0 Then
            contdistrito = c
            insertar("INSERT INTO DISTRITO VALUES(" + idprovincia + ",'" + contcanton.ToString() + "'," & contdistrito & ",'" + distrito + "'" + ")")
            d = d + 1
        End If
    End Sub


    Public Function contar_filas() As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM DISTRITO ", "DISTRITO")
        If ds.Tables("DISTRITO").Rows.Count = 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function

    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Sub insertar(ByVal sql As String)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub Borrar(ByVal sql As String)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Public Function cargarprovincia() As DataTable
        Dim dt = New DataTable()
        consultar("SELECT CODIGO_PROVINCIA, DESCRIPCION_PROVINCIA FROM PROVINCIA WHERE  CODIGO_PROVINCIA NOT IN(6,8) ORDER BY 1", "PROVINCIA")
        da.Fill(dt)
        Return dt
    End Function
    Public Function cargarcanton(ByVal idprovincia As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT CODIGO_CANTON, DESCRIPCION_CANTON FROM CANTON  WHERE CODIGO_PROVINCIA=" + idprovincia + "ORDER BY 1", "CANTON")
        da.Fill(dt)
        Return dt
    End Function
    Public Function carga_distrito(ByVal idcanton As String, ByVal idprovincia As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT CODIGO_DISTRITO, DESCRIPCION_DISTRITO FROM DISTRITO WHERE CODIGO_PROVINCIA=" + idprovincia + " AND CODIGO_CANTON=" + idcanton + "ORDER BY 1", "DISTRITO")
        da.Fill(dt)
        Return dt
    End Function

End Class
