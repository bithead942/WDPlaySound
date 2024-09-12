Module Module1
    Dim Synthesizer1 As New System.Speech.Synthesis.SpeechSynthesizer
    Dim WavPlay1 As New System.Media.SoundPlayer
    Dim strPath As String = "c:\Progra~1\Watchdog\"

    Sub Main(ByVal CmdArgs() As String)

        If CmdArgs.Length > 0 Then
            'Door Opened
            If CmdArgs(0) = "1001" Or CmdArgs(0) = "2007" Or CmdArgs(0) = "2011" Or CmdArgs(0) = "2017" Or CmdArgs(0) = "2037" Then
                WavPlay1.SoundLocation() = strPath & "Door_Opened.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Door Closed
            If CmdArgs(0) = "1002" Or CmdArgs(0) = "2008" Or CmdArgs(0) = "2012" Or CmdArgs(0) = "2018" Or CmdArgs(0) = "2038" Then
                WavPlay1.SoundLocation() = strPath & "Door_Closed.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Garage Door Opened
            If CmdArgs(0) = "2001" Then
                WavPlay1.SoundLocation() = strPath & "GDoor_Up.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Garage Door Closed
            If CmdArgs(0) = "2002" Then
                WavPlay1.SoundLocation() = strPath & "GDoor_Down.wav"
                WavPlay1.PlaySync()
            End If

            'Door Unlocked
            If CmdArgs(0) = "1003" Or CmdArgs(0) = "2009" Or CmdArgs(0) = "2013" Or CmdArgs(0) = "2019" Or CmdArgs(0) = "2039" Then
                WavPlay1.SoundLocation() = strPath & "Door_Unlocked.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Door Unlocked
            If CmdArgs(0) = "1004" Or CmdArgs(0) = "2010" Or CmdArgs(0) = "2014" Or CmdArgs(0) = "2020" Or CmdArgs(0) = "2040" Then
                WavPlay1.SoundLocation() = strPath & "Door_Locked.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Motion Detected
            If CmdArgs(0) = "6002" Then
                WavPlay1.SoundLocation() = strPath & "Motion_Detected.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Intruder Detected
            If CmdArgs(0) = "5014" Then
                WavPlay1.SoundLocation() = strPath & "Intruder.wav"
                Try
                    WavPlay1.PlaySync()
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Mail Alert
            If CmdArgs(0) = "5001" Then
                Try
                    Synthesizer1.Speak("Youve got Mail")
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Too Hot
            If CmdArgs(0) = "5018" Or CmdArgs(0) = "5020" Or CmdArgs(0) = "5022" Then
                Try
                    Synthesizer1.Speak("Is it just me, or is it warm in here?")
                Catch ex As Exception
                    Exit Sub
                End Try
            End If

            'Too Cold
            If CmdArgs(0) = "5019" Or CmdArgs(0) = "5021" Then
                Try
                    Synthesizer1.Speak("Is it just me, or is it cold in here?")
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
        End If

    End Sub

End Module
