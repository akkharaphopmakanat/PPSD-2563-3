'Description Of this Program

'Author : Oakkharaphop  Makanat
'Since : 2021-04-25

'Program Name : Read , Write , Append , Delete File
'Program Language : VB.NET
'Program Purpose : Write a small program

Imports System
Module Program
    Sub Main(args As String()) 'Main Sub
        Console.WriteLine("Please input directory and file name. (example C:\foldername\filename.txt) or input 'cur' as currentdirectory\file.txt")
        Dim fd = Console.ReadLine() 'fd is value from keyboard input
        If fd = "cur" Then 'compare if fd is "cur" it will set to currentdir\file.txt
            fd = System.IO.Directory.GetCurrentDirectory + "\file.txt"
        End If
        If Not System.IO.File.Exists(fd) Then 'if file does not exist , create file first to avoid exeption
            System.IO.File.Create(fd)
        End If
        Console.WriteLine("Selected file : " & fd)
        Console.WriteLine("Please select your action : " & vbCrLf & "R : Read File" & vbCrLf & "W : Write File" & vbCrLf & "A : Append" & vbCrLf & "D : Delete File")
        Dim at = Console.ReadLine() 'at is value from keyboard input
        Select Case at
            Case "R"
                Dim fileReader As String = System.IO.File.ReadAllText(fd) 'declare fileReader as System's read all t in file
                Console.WriteLine("Content in file is : ")
                Console.WriteLine(fileReader)
            Case "W"
                Console.WriteLine("Please enter t to write : ")
                Dim t = Console.ReadLine() 't is value from keyboard input use for Write to file
                Dim writer As New System.IO.StreamWriter(fd) 'declare writer as new StreamWriter 
                writer.Write(t)
                writer.Close()
            Case "A"
                Console.WriteLine("Please enter t to append : ")
                Dim t = Console.ReadLine() 't is value from keyboard input use for Append to file
                System.IO.File.AppendAllText(fd, t)
            Case "D"
                System.IO.File.Delete(fd)
            Case Else
                Console.WriteLine("Invalid at")
        End Select
    End Sub
End Module


