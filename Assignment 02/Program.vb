Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("Please input directory and file name. (example C:\foldername\filename.txt) or input 'cur' as currentdirectory\file.txt")
        Dim fileDir = Console.ReadLine()
        If fileDir = "cur" Then
            fileDir = System.IO.Directory.GetCurrentDirectory + "\file.txt"
        End If
        If Not System.IO.File.Exists(fileDir) Then
            System.IO.File.Create(fileDir)
        End If
        Console.WriteLine("Selected file : " & fileDir)
        Console.WriteLine("Please select your action : " & vbCrLf & "R : Read File" & vbCrLf & "W : Write File" & vbCrLf & "A : Append" & vbCrLf & "D : Delete File")
        Dim action = Console.ReadLine()
        Select Case action
            Case "R"
                Dim fileReader As String = System.IO.File.ReadAllText(fileDir)
                Console.WriteLine("Content in file is : ")
                Console.WriteLine(fileReader)
            Case "W"
                Console.WriteLine("Please enter text to write : ")
                Dim text = Console.ReadLine()
                Dim writer As New System.IO.StreamWriter(fileDir)
                writer.Write(text)
                writer.Close()
            Case "A"
                Console.WriteLine("Please enter text to append : ")
                Dim text = Console.ReadLine()
                System.IO.File.AppendAllText(fileDir, text)
            Case "D"
                System.IO.File.Delete(fileDir)
            Case Else
                Console.WriteLine("Invalid Action")
        End Select
    End Sub
End Module


