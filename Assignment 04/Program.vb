'Description Of this Program

'Author : Oakkharaphop  Makanat
'Since : 2021-04-25

'Program Name : Read , Write , Append , Delete File
'Program Language : VB.NET
'Program Purpose : Write a small program

Imports System
Module Program
    Sub Main() 'Main Sub
        Console.WriteLine("Please input directory and file name. (example C:\foldername\filename.txt) or input 'cur' as currentdirectory\file.txt")
        Dim fileDir = Console.ReadLine() 'fileDir is value from keyboard input
        If fileDir = "cur" Then 'compare if fileDir is "cur" it will set to currentdir\file.txt
            fileDir = System.IO.Directory.GetCurrentDirectory + "\file.txt"
        End If
        If Not System.IO.File.Exists(fileDir) Then 'if file does not exist , create file first to avoid exeption
            System.IO.File.Create(fileDir)
        End If
        Console.WriteLine("Selected file : " & fileDir)
        Console.WriteLine("Please select your action : " & vbCrLf & "R : Read File" & vbCrLf & "W : Write File" & vbCrLf & "A : Append" & vbCrLf & "D : Delete File")
        Dim action = Console.ReadLine() 'action is value from keyboard input
        Select Case action
            Case "R"
                ReadFile(fileDir)
            Case "W"
                WriteFile(fileDir)
            Case "A"
                AppendFile(fileDir)
            Case "D"
                DeleteFile(fileDir)
            Case Else
                Console.WriteLine("Invalid Action")
                Main()
        End Select
    End Sub
    Sub ReadFile(fileDir)
        Dim fileReader As String = System.IO.File.ReadAllText(fileDir) 'declare fileReader as System's read all text in file
        Console.WriteLine("Content in file is : ")
        Console.WriteLine(fileReader)
    End Sub
    Sub WriteFile(fileDir)
        System.IO.File.WriteAllText(fileDir, "")
        Console.WriteLine("Please enter text to write : ")
        Dim text = Console.ReadLine() 'text is value from keyboard input use for Write to file
        If Integer.TryParse(text, vbNull) Then
            System.IO.File.AppendAllText(fileDir, text + " ")
            AppendFile(fileDir)
        ElseIf text = "." Then
            Exit Sub
        Else
            Console.WriteLine("Please input number or . to stop")
            WriteFile(fileDir)
        End If
    End Sub
    Sub AppendFile(fileDir)
        Console.WriteLine("Please enter text to append : ")
        Dim text = Console.ReadLine() 'text is value from keyboard input use for Append to file
        If Integer.TryParse(text, vbNull) Then
            System.IO.File.AppendAllText(fileDir, text + " ")
            AppendFile(fileDir)
        ElseIf text = "." Then
            Exit Sub
        Else
            Console.WriteLine("Please input number or . to stop")
            WriteFile(fileDir)
        End If
    End Sub
    Sub DeleteFile(fileDir)
        System.IO.File.Delete(fileDir)
    End Sub
End Module


