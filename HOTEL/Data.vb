Imports System.Data
Imports System.Data.SqlClient
Public Class Data


    Private conn As New SqlConnection
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private ds As DataSet
    Public Function data_fill(ByVal qry As String) As DataTable
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        dt = New DataTable
        da = New SqlDataAdapter(qry, conn)
        conn.Open()
        da.SelectCommand.ExecuteReader()
        conn.Close()
        da.Fill(dt)
        Return dt
    End Function
    Public Function data_fill_ds(ByVal qry As String) As DataSet
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        ds = New DataSet
        da = New SqlDataAdapter(qry, conn)
        conn.Open()
        da.SelectCommand.ExecuteReader()
        conn.Close()
        da.Fill(ds)
        Return ds
    End Function



    Public Function data_set(ByVal str As String) As DataSet
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        ds = New DataSet
        da = New SqlDataAdapter(str, conn)
        conn.Open()
        conn.Close()
        da.Fill(ds, "H_Item")
        Return ds
    End Function
    Public Sub update_data(ByVal qry As String)
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Sub insert_data(ByVal str As String)
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim cmd As New SqlCommand(str, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function NValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
        If (c <> "" AndAlso IsNumeric(c)) Or hc = 524296 Or hc = 851981 Or c = vbBack Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function TValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
        If (LCase(c) >= "a" And LCase(c) <= "z") Or hc = 524296 Or hc = 2097184 Or c = vbBack Or hc = 7244975 Or c = " " Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ANValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
        If ((IsNumeric(c) AndAlso c <> "") Or LCase(c) >= "a" And LCase(c) <= "z") Or hc = 524296 Or hc = 2097184 Or hc = 2883628 Or hc = 2949165 Or hc = 3014702 Or hc = 3080239 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function EValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
        If ((IsNumeric(c) AndAlso c <> "") Or LCase(c) >= "a" And LCase(c) <= "z") Or hc = 524296 Or hc = 2097184 Or hc = 3014702 Or hc = 524296 Or hc = 4194368 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Validate(ByVal qry As String) As Boolean
        Dim f As Boolean = False
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader()
        While obj.Read()
            f = True
            Exit While
        End While
        conn.Close()
        Return f
    End Function

    Public Function Search_Cutomer(ByVal qry As String) As Integer
        Dim id As Integer = -1
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader()
        While obj.Read()
            id = obj.Item("C_Id")
            Exit While
        End While
        Return id
    End Function

    Public Function geninvc() As String
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("SELECT NEXT VALUE FOR dbo.ivc_gen")
        conn.Open()
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ivc_no As String = dr.Item(0).ToString
        conn.Close()
        Return ivc_no
    End Function

    Public Function get_one_feild(ByVal qry As String) As Integer
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim obj As SqlDataReader
        Dim value As Integer
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader()
        If obj.Read Then
            value = Val(obj.Item(0))
        Else
            value = 0
        End If
        conn.Close()
        Return value
    End Function

    Public Function get_feild(ByVal qry As String) As String
        conn.ConnectionString = "Data Source=DESKTOP-SHA2H0O;Initial Catalog=THE_SHIV_GRAND;Integrated Security=True"
        Dim obj As SqlDataReader
        Dim str As String
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader()
        If obj.Read Then
            str = (obj.Item(0))
        Else
            str = vbNull
        End If
        conn.Close()
        Return str
    End Function

End Class

