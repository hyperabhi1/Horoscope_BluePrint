Sub match_key(ByVal m_planet As String, ByVal combo() As String, ByVal xkey As String, ByVal Cuspp() As String, ByVal cloc As String, ByVal pflag As String)
        Dim fl1 As String = "N"
        Dim fl2 As String = "N"
        Dim fl3 As String = "N"
        Dim fl4 As String = "N"
        Dim fl5 As String = "N"
        Dim fl6 As String = "N"
        Dim fl7 As String = "N"
        Dim fl8 As String = "N"
        Dim m_str As String = ""
        Dim xcusp(Cuspp.Length - 1) As String
        Dim xcombo(combo.Length - 1) As String

        Dim pstr1 As String = ""
        For i As Integer = 0 To combo.Length - 1
            pstr1 = pstr1 + combo(i)
        Next

        Dim pstr2 As String = ""
        For i As Integer = 0 To Cuspp.Length - 1
            pstr2 = pstr2 + Cuspp(i)
        Next

        'Check first position
        Array.Copy(Cuspp, xcusp, Cuspp.Length)
        Array.Copy(combo, xcombo, combo.Length)

        For i As Integer = 0 To xcusp.Length - 1
            If xcombo(0) = xcusp(i) Then
                m_str = m_str + xcombo(0)
                xcusp(i) = "XX"
                fl1 = "Y"
                m_str = m_str
                Exit For
            End If
            If xcombo(0) = Cuspp(i) Then
                m_str = m_str + xcombo(0)
                fl1 = "Y"
            End If
        Next

        If fl1 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(1) = xcusp(i) Then
                    m_str = m_str + xcombo(1)
                    xcusp(i) = "XX"
                    fl2 = "Y"
                    Exit For
                End If
                If xcombo(1) = Cuspp(i) Then
                    m_str = m_str + xcombo(1)
                    fl2 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(2) = xcusp(i) Then
                    m_str = m_str + xcombo(2)
                    xcusp(i) = "XX"
                    fl3 = "Y"
                    Exit For
                End If
                If xcombo(2) = Cuspp(i) Then
                    m_str = m_str + xcombo(2)
                    fl3 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(3) = xcusp(i) Then
                    m_str = m_str + xcombo(3)
                    xcusp(i) = "XX"
                    fl4 = "Y"
                    Exit For
                End If
                If xcombo(3) = Cuspp(i) Then
                    m_str = m_str + xcombo(3)
                    fl4 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" And fl4 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(4) = xcusp(i) Then
                    m_str = m_str + xcombo(4)
                    xcusp(i) = "XX"
                    fl5 = "Y"
                    Exit For
                End If
                If xcombo(4) = Cuspp(i) Then
                    m_str = m_str + xcombo(4)
                    fl5 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" And fl4 = "Y" And fl5 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(5) = xcusp(i) Then
                    m_str = m_str + xcombo(5)
                    xcusp(i) = "XX"
                    fl6 = "Y"
                    Exit For
                End If
                If xcombo(5) = Cuspp(i) Then
                    m_str = m_str + xcombo(5)
                    fl6 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" And fl4 = "Y" And fl5 = "Y" And fl6 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(6) = xcusp(i) Then
                    m_str = m_str + xcombo(6)
                    xcusp(i) = "XX"
                    fl7 = "Y"
                    Exit For
                End If
                If xcombo(6) = Cuspp(i) Then
                    m_str = m_str + xcombo(6)
                    fl7 = "Y"
                End If
            Next
        End If

        If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" And fl4 = "Y" And fl5 = "Y" And fl6 = "Y" And fl7 = "Y" Then
            For i As Integer = 0 To xcusp.Length - 1
                If xcombo(7) = xcusp(i) Then
                    m_str = m_str + xcombo(7)
                    xcusp(i) = "XX"
                    fl8 = "Y"
                    Exit For
                End If
                If xcombo(7) = Cuspp(i) Then
                    m_str = m_str + xcombo(7)
                    fl8 = "Y"
                End If
            Next
        End If

        Dim pattern As Boolean = True
        For i As Integer = 0 To xcusp.Length - 1
            If xcusp(i) IsNot "XX" Then
                pattern = False
            End If
        Next

        If pattern = True Then
            Dim n As Integer = 0
            Dim query As String
            If pflag = "Y" Then
                If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" And fl4 = "Y" Then
                    n = 4
                End If
                If fl1 = "Y" And fl2 = "Y" And fl3 = "Y" Then
                    n = 3
                End If
            End If
            Dim con As New SqlConnection(connstr)
            Dim connection As SqlConnection = New SqlConnection(connstr)
            connection.Open()
            query = "INSERT INTO MATCH_FILE_" + m_planet + " VALUES ('" + uid + "','" + hid + "','" + m_planet + "','" + xkey + "','" + pstr1 + "','" + cloc + "','" + pstr2 + "','" + m_str + "','" + n.ToString() + "','" + pflag + "')"
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            connection.Close()
            MatchedFileCounter = MatchedFileCounter + 1
        End If
    End Sub