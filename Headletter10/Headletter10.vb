Sub Process_match_Key_set(ByVal RowsData As DataSet, ByRef m_planet As String)
        ThreadStartCounter += 1
        Dim a8(55) As String
        While counter > -1
            Dim i = counter
            counter -= 1
            Try
                Dim pa = m_planet
                Dim p1 = RowsData.Tables(0).Rows(i)(0).Trim.ToString()
                Dim p2 = RowsData.Tables(0).Rows(i)(1).Trim.ToString()
                Dim p3 = RowsData.Tables(0).Rows(i)(2).Trim.ToString()
                Dim p4 = RowsData.Tables(0).Rows(i)(3).Trim.ToString()
                Dim p5 = RowsData.Tables(0).Rows(i)(4).Trim.ToString()
                Dim p6 = RowsData.Tables(0).Rows(i)(5).Trim.ToString()
                Dim m_key = pa + p1 + p2 + p3 + p4 + p5 + p6

                a8(0) = pa
                a8(1) = p1
                a8(2) = p2
                a8(3) = p3
                a8(4) = p4
                a8(5) = p5
                a8(6) = p6

                a8(7) = pa
                a8(8) = p6
                a8(9) = p5
                a8(10) = p4
                a8(11) = p3
                a8(12) = p2
                a8(13) = p1

                a8(14) = p1
                a8(15) = p2
                a8(16) = p3
                a8(17) = p4
                a8(18) = p5
                a8(19) = p6
                a8(20) = pa

                a8(21) = p1
                a8(22) = pa
                a8(23) = p6
                a8(24) = p5
                a8(25) = p4
                a8(26) = p3
                a8(27) = p2

                a8(28) = p2
                a8(29) = p3
                a8(30) = p4
                a8(31) = p5
                a8(32) = p6
                a8(33) = pa
                a8(34) = p1

                a8(35) = p2
                a8(36) = p1
                a8(37) = pa
                a8(38) = p6
                a8(39) = p5
                a8(40) = p4
                a8(41) = p3

                a8(42) = p3
                a8(43) = p4
                a8(44) = p5
                a8(45) = p6
                a8(46) = pa
                a8(47) = p1
                a8(48) = p2

                a8(49) = p3
                a8(50) = p2
                a8(51) = p1
                a8(52) = pa
                a8(53) = p6
                a8(54) = p5
                a8(55) = p4

                Parallel.Invoke(
                Sub() Match_Key(pa, m_key, a8, c01, "01"),
                Sub() Match_Key(pa, m_key, a8, c02, "02"),
                Sub() Match_Key(pa, m_key, a8, c03, "03"),
                Sub() Match_Key(pa, m_key, a8, c04, "04"),
                Sub() Match_Key(pa, m_key, a8, c05, "05"),
                Sub() Match_Key(pa, m_key, a8, c06, "06"),
                Sub() Match_Key(pa, m_key, a8, c07, "07"),
                Sub() Match_Key(pa, m_key, a8, c08, "08"),
                Sub() Match_Key(pa, m_key, a8, c09, "09"),
                Sub() Match_Key(pa, m_key, a8, c10, "10"),
                Sub() Match_Key(pa, m_key, a8, c11, "11"),
                Sub() Match_Key(pa, m_key, a8, c12, "12"))
            Catch ex As Exception
                Exit While
            End Try
        End While
        ThreadEndCounter += 1
    End Sub
    Sub Match_Key(ByRef m_planet As String, ByVal m_key As String, ByVal combo() As String, ByVal Cuspp() As String, ByVal cloc As String)
        Dim y2() As String = {"YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY", "YY"}
        Dim c = Cuspp.Length - 1
        Dim z1(c) As String
        Dim mstr = ""
        For i As Integer = 0 To 55
            For j As Integer = 0 To c
                If combo(i) = Cuspp(j) Then
                    y2(i) = "XX"
                End If
            Next
        Next
        For mega As Integer = 0 To 7
            Dim pstr2 = ""
            mstr = ""
            Array.Copy(Cuspp, z1, c)
            Dim start = (mega) * 6
            Dim finish = start + 5
            For i = start To finish
                If y2(i) IsNot "XX" Then
                    Exit For
                End If
                For j = 0 To c
                    If z1(j) = combo(i) Then
                        z1(j) = "XX"
                        mstr = mstr + combo(i)
                        Exit For
                    Else
                        If Cuspp(j) = combo(i) Then
                            mstr = mstr + combo(i)
                        End If
                    End If
                Next
            Next
            Dim pattern As Boolean = True
            For m As Integer = 0 To c
                If z1(m) IsNot "XX" Then
                    pattern = False
                End If
            Next
            If pattern = True Then
                For i As Integer = 0 To c
                    pstr2 = pstr2 + Cuspp(i)
                Next
                Dim uid As String = "XXXXXXXXXX"
                Dim hid As String = "100001"
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Try
                    con.ConnectionString = connstr
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO MATCH_FILE VALUES ('" + uid + "','" + hid + "','" + m_planet + "','" + m_key + "','" + cloc + "','" + pstr2 + "');"
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                Finally
                    con.Close()
                End Try
            End If
        Next
    End Sub