﻿Imports System.IO
Imports System.Text
Imports System.Security
Imports System.Security.Cryptography
Imports ST = System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Module modDB
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdRead As MySqlDataReader
    Public db_server As String = "'localhost'"
    Public db_uid As String = "'root'"
    Public db_pwd As String = "''"
    Public db_name As String = "'company'"
    Public strConnection As String = "server=" & db_server & ";uid=" & db_uid & ";password=" & db_pwd & ";database=" & db_name & ";" & "allowuservariables='True';"

    Public Structure LoggedUser
        Dim id As Integer
        Dim name As String
        Dim position As String
        Dim username As String
        Dim password As String
        Dim type As Integer
    End Structure

    Public Sub UpdateConnectionString()
        Try
            Dim config As String = System.IO.Directory.GetCurrentDirectory & "\confignijake.txt"
            If System.IO.File.Exists(config) Then
                Dim lines As String() = System.IO.File.ReadAllLines(config)
                If lines.Length >= 4 Then
                    Dim settings As New Dictionary(Of String, String)
                    For Each line As String In lines
                        Dim parts As String() = line.Split("="c)
                        If parts.Length = 2 Then
                            settings(parts(0).Trim()) = parts(1).Trim()
                        End If
                    Next

                    If settings.ContainsKey("server") AndAlso
                   settings.ContainsKey("uid") AndAlso
                   settings.ContainsKey("password") AndAlso
                   settings.ContainsKey("database") Then

                        strConnection = $"server={settings("server")};uid={settings("uid")};password={settings("password")};database={settings("database")};allowuservariables=True;"
                    Else
                        MsgBox("Config file missing required settings.")
                    End If
                Else
                    MsgBox("Config file does not contain enough lines.")
                End If
            Else
                MsgBox("Config file does not exist: " & config)
            End If
        Catch ex As Exception
            MsgBox("Error updating connection string: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public CurrentLoggedUser As LoggedUser = Nothing
    Public Sub openConn(ByVal db_name As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConnection
                .Open()
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub readQuery(ByVal sql As String)
        Try
            openConn(db_name)
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdRead = .ExecuteReader
            End With
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function isConnectedToLocalServer() As Boolean
        Dim result As Boolean = False
        Try
            myadocon = New MySqlConnection
            myadocon.ConnectionString = strConnection
            Try
                myadocon.Open()
                If myadocon.State = ConnectionState.Open Then
                    result = True
                Else
                    result = False
                End If
            Catch ex As Exception
                Return False
            End Try
            If myadocon.State = ConnectionState.Open Then
                myadocon.Close()
            End If
        Catch
            Return False
        End Try
        Return result
    End Function

    Function LoadToDGV(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return 0
    End Function

    Function LoadToDGVForDisplay(ByVal query As String, ByVal dgv As DataGridView) As Integer
        Try
            readQuery(query)
            Dim dt As DataTable = New DataTable
            dt.Load(cmdRead)
            dgv.DataSource = dt
            dgv.Refresh()
            If dgv.ColumnCount > 1 Then
                dgv.Columns(0).Visible = False
            End If
            Return dgv.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return 0
    End Function

    Public Function Encrypt(ByVal clearText As String) As String

        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Sub Logs(ByVal transaction As String, Optional ByVal events As String = "*_Click")
        Try
            readQuery(String.Format("INSERT INTO `logs`(`dt`, `user_accounts_id`, `event`, `transactions`) VALUES ({0},{1},'{2}','{3}')", "now()", _
                                    CurrentLoggedUser.id, _
                                    events, _
                                    transaction))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
