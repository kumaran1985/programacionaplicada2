Public Class Watcher 
    Public Shared Sub Main()
        Dim args() As String = System.Environment.GetCommandLineArgs()
        ' If a directory is not specified, exit the program.
        If args.Length <> 2 Then
            ' Display the proper way to call the program.
            Console.WriteLine("Usage: Watcher.exe (directory)")
            Return
        End If

        ' Create a new FileSystemWatcher and set its properties.
        Dim watcher As New FileSystemWatcher()
        watcher.Path = args(1)
        ' Watch for changes in LastAccess and LastWrite times, and
        ' the renaming of files or directories. 
        watcher.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        ' Only watch text files.
        watcher.Filter = "*.txt"

        ' Add event handlers.
        AddHandler watcher.Changed, AddressOf OnChanged
        AddHandler watcher.Created, AddressOf OnChanged
        AddHandler watcher.Deleted, AddressOf OnChanged
        AddHandler watcher.Renamed, AddressOf OnRenamed

        ' Begin watching.
        watcher.EnableRaisingEvents = True

        ' Wait for the user to quit the program.
        Console.WriteLine("Press 'q' to quit the sample.")
        While Chr(Console.Read()) <> "q"c
        End While
    End Sub

    ' Define the event handlers.
    Private Shared Sub OnChanged(ByVal source As Object, ByVal e As FileSystemEventArgs)
        ' Specify what is done when a file is changed, created, or deleted.
        Console.WriteLine("File: " & e.FullPath & " " & e.ChangeType)
    End Sub

    Private Shared Sub OnRenamed(ByVal source As Object, ByVal e As RenamedEventArgs)
        ' Specify what is done when a file is renamed.
        Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath)
    End Sub



    Sub pintar()
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("function rellenar(id,cuantos){                                                                                ")
        sb.AppendLine("	//document.getElementById(id).innerHTML=""""                                                                   ")
        sb.AppendLine("	for(i=0;i<cuantos;i++){                                                                                      ")
        sb.AppendLine("		document.getElementById(id).innerHTML+=(Math.round(Math.random()));                                        ")
        sb.AppendLine("	}	                                                                                                           ")
        sb.AppendLine("	//setTimeout(""rellenar('""+id+""',""+cuantos+"")"",500);                                                          ")
        sb.AppendLine("}                                                                                                             ")
        sb.AppendLine("function pintar(){                                                                                            ")
        sb.AppendLine("rellenar(""linea1"",26);                                                                                        ")
        sb.AppendLine("document.getElementById(""linea1"").innerHTML+='<%=Session(""IdentificacionUsuarioLogin"")%>';                    ")
        sb.AppendLine("rellenar(""linea1"",70);                                                                                        ")
        sb.AppendLine("document.getElementById(""linea1"").innerHTML+='<%=left(Session(""IdentificacionUsuarioLogin""),8)%>';            ")
        sb.AppendLine("rellenar(""linea1"",3);                                                                                         ")
        sb.AppendLine("rellenar(""linea2"",120);                                                                                       ")
        sb.AppendLine("document.getElementById(""linea2"").innerHTML+='<%=Session(""IdentificacionUsuarioLogin"").Substring(8, 8)%>';    ")
        sb.AppendLine("rellenar(""linea2"",3);                                                                                         ")
        sb.AppendLine("rellenar(""linea3"",146);                                                                                       ")
        sb.AppendLine("rellenar(""linea4"",146);                                                                                       ")
        sb.AppendLine("rellenar(""linea5"",120);                                                                                       ")
        sb.AppendLine("document.getElementById(""linea5"").innerHTML+='<%=right(Session(""IdentificacionUsuarioLogin""),8)%>';           ")
        sb.AppendLine("rellenar(""linea5"",3);                                                                                         ")
        sb.AppendLine("rellenar(""linea6"",95);                                                                                        ")
        sb.AppendLine("document.getElementById(""linea6"").innerHTML+='<%=StrReverse(Session(""IdentificacionUsuarioLogin""))%>';        ")
        sb.AppendLine("}          ")
        sb.AppendLine("pintar();")
    End Sub

End Class


