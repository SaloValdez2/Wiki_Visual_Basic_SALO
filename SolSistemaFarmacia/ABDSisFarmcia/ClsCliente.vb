Imports System.Data.SqlClient

Public Class ClsCliente
    Public Function LISTAR_CLIENTE_CONSULTA1() As DataSet
        Dim Ds As New DataSet
        Dim OBJ As New ClsConexion
        Using Cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using Cmd As New SqlCommand
                    Cn.ConnectionString = OBJ.Conexion()
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.CommandText = "usp_listar_cliente_tipo"
                    Cmd.Connection = Cn
                    da.SelectCommand = Cmd
                    Cn.Open()
                    da.Fill(ds)
                    Cn.Close()
                End Using
            End Using
        End Using
        Return Ds
    End Function

    'FRM_LISTAR_CANTIDAD_CLINETES'
    Public Function LISTAR_CLIENTE_CONSULTA2() As DataSet
        Dim Ds As New DataSet
        Dim OBJ As New ClsConexion
        Using Cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using Cmd As New SqlCommand
                    Cn.ConnectionString = OBJ.Conexion()
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.CommandText = "USP_LISTAR_CLIENTE_CANTIDAD"
                    Cmd.Connection = Cn
                    da.SelectCommand = Cmd
                    Cn.Open()
                    da.Fill(Ds)
                    Cn.Close()
                End Using
            End Using
        End Using
        Return Ds
    End Function



End Class
