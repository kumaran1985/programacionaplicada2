Imports System.Xml
Imports System.IO

''' <summary>
''' Retorna un valor pasandole la ruta del XML
''' </summary>
Public NotInheritable Class ConfigXML
    'Inherits AbstractConfigurationXML

    ''' <summary>
    ''' instancia del documento actual
    ''' </summary>
    Private Shared _currentDocument As XmlDocument
    Private Shared _currentPath As String
    Private Shared _GetKeyValueTable As Hashtable
    Private Shared _GetKeyValueOverloadsTable As Hashtable
    Private Shared _GetNodeTextTable As Hashtable
    Private Shared _GetNodeSectionTable As Hashtable
    Protected Shared ApplicationPath As String
    Private Shared WithEvents watcher As New FileSystemWatcher()
    Shared Sub New()
        ClearValues()
        _currentPath = Nothing

        ' ApplicationPath = System.IO.Path.GetDirectoryName(GetType(Config).Assembly.CodeBase).Remove(0, "file:\".Length) & "\"

    End Sub


    Private Shared Sub ClearValues()
        _currentDocument = Nothing
        _GetKeyValueTable = Nothing
        _GetNodeTextTable = Nothing
        _GetKeyValueOverloadsTable = Nothing
        _GetNodeSectionTable = Nothing
    End Sub


    Private Event onGetCompleteNode As EventHandler

    Private Event onGetDocument As EventHandler

    Private Event onGetKeyValue As EventHandler

    Private Event onGetNodeText As EventHandler

    Private Shared Sub sWatcher()


        watcher.Path = System.IO.Path.GetDirectoryName(CurrentPath)
        ' Watch for changes in LastAccess and LastWrite times, and
        ' the renaming of files or directories. 
        watcher.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
        ' Only watch text files.
        watcher.Filter = System.IO.Path.GetFileName(CurrentPath)

        ' Add event handlers.
        AddHandler watcher.Changed, AddressOf OnChanged
        AddHandler watcher.Created, AddressOf OnChanged
        AddHandler watcher.Deleted, AddressOf OnChanged
        AddHandler watcher.Renamed, AddressOf OnRenamed

        ' Begin watching.
        watcher.EnableRaisingEvents = True
    End Sub



    Private Shared Sub OnChanged(ByVal source As Object, ByVal e As FileSystemEventArgs)
        loadXML()
    End Sub

    Private Shared Sub OnRenamed(ByVal source As Object, ByVal e As RenamedEventArgs)
        loadXML()
    End Sub

    Private Shared ReadOnly Property GetNodeSectionTable() As Hashtable
        Get
            If _GetNodeSectionTable Is Nothing Then
                _GetNodeSectionTable = New Hashtable
            End If
            Return _GetNodeSectionTable
        End Get
    End Property


    Private Shared ReadOnly Property GetNodeTextTable() As Hashtable
        Get
            If _GetNodeTextTable Is Nothing Then
                _GetNodeTextTable = New Hashtable
            End If
            Return _GetNodeTextTable
        End Get
    End Property


    Private Shared ReadOnly Property GetKeyValueOverloadsTable() As Hashtable
        Get
            If _GetKeyValueOverloadsTable Is Nothing Then
                _GetKeyValueOverloadsTable = New Hashtable
            End If
            Return _GetKeyValueOverloadsTable
        End Get
    End Property

    Private Shared ReadOnly Property GetKeyValueTable() As Hashtable
        Get
            If _GetKeyValueTable Is Nothing Then
                _GetKeyValueTable = New Hashtable
            End If
            Return _GetKeyValueTable
        End Get
    End Property


    Public Shared ReadOnly Property CurrentDocument() As XmlDocument
        Get
            If _currentDocument Is Nothing Then loadXML()
            Return _currentDocument
        End Get

    End Property

    Public Shared Property CurrentPath() As String
        Get
            If _currentPath Is Nothing Then
                _currentPath = ApplicationPath & "config.xml"
            End If
            If Not System.IO.File.Exists(_currentPath) Then
                Throw New Exception(GetType(ConfigXML).FullName & ": No Existe el archivo de configuración: " & _currentPath & " No se puede inicializar la aplicacion")
            End If

            Return _currentPath
        End Get
        Set(ByVal value As String)
            If Not System.IO.File.Exists(value) Then
                Throw New Exception(GetType(ConfigXML).FullName & ": No Existe el archivo de configuración: " & value & " No se puede inicializar la aplicacion")
            End If
            _currentPath = value
            sWatcher()
            loadXML()
        End Set
    End Property

    Public Shared Function GetNodeText(ByVal xmlPath As String) As String
        If CurrentDocument Is Nothing Then Throw New Exception("No se ha cargado el documento")

        If GetNodeTextTable.ContainsKey(xmlPath) Then
            Return GetNodeTextTable.Item(xmlPath).ToString
        End If

        Try
            Dim valueToReturn As String = CurrentDocument.SelectSingleNode(xmlPath).InnerText.ToString()
            GetNodeTextTable.Add(xmlPath, valueToReturn)
            Return valueToReturn

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function

    ''' <summary>
    ''' Retorna un atributo identificado por el atributo Key /value
    ''' del nodo en forma /add key="" value=""
    ''' </summary>
    Public Shared Function GetKeyValue(ByVal Key As String) As String
        If CurrentDocument Is Nothing Then Throw New Exception("No se ha cargado el documento")
        If GetKeyValueTable.ContainsKey(Key) Then
            Return GetKeyValueTable.Item(Key).ToString
        End If
        Dim valueToReturn As String = GetKeyValue("key", "value", "//Add")
        GetKeyValueTable.Add(Key, valueToReturn)
        Return valueToReturn

    End Function


    Public Shared Function GetKeyValue(ByVal KeyName As String, ByVal KeyValue As String, ByVal Section As String) As String
        If CurrentDocument Is Nothing Then Throw New Exception("No se ha cargado el documento")
        If GetKeyValueOverloadsTable.ContainsKey(KeyName) Then
            Return GetKeyValueOverloadsTable.Item(KeyName).ToString
        End If

        Try

            For Each nodo As XmlNode In CurrentDocument.SelectNodes(Section)
                For Each a As XmlAttribute In nodo.Item(KeyName).Attributes
                    If a.Name.ToString = KeyValue Then
                        GetKeyValueOverloadsTable.Add(KeyName, a.Value)
                        Return a.Value
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

        Return Nothing
    End Function


    ''' <summary>
    ''' Retorna una lista de nodos XML pasandole el path
    ''' </summary>
    Public Shared Function GetNodeSection(ByVal NodePath As String) As Xml.XmlNodeList
        If CurrentDocument Is Nothing Then Throw New Exception("No se ha cargado el documento")
        If GetNodeSectionTable.ContainsKey(NodePath) Then
            Return TryCast(GetNodeSectionTable.Item(NodePath), Xml.XmlNodeList)
        End If

        Try

            If CurrentDocument.HasChildNodes = True Then
                GetNodeSectionTable.Add(NodePath, CurrentDocument.SelectNodes(NodePath))
                Return TryCast(GetNodeSectionTable.Item(NodePath), Xml.XmlNodeList)
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing
    End Function

    ''' <summary>
    ''' Retorna un Documento
    ''' </summary>
    Public Shared Function GetDocument() As Xml.XmlDocument
        Return CurrentDocument
    End Function


    Private Shared Sub loadXML()
        ClearValues()

        _currentDocument = New XmlDocument

        Try
            System.Threading.Thread.Sleep(500)
            _currentDocument.Load(CurrentPath)
        Catch ex As Exception
            Throw New Exception("No se puede cargar el archivo de configuración XML: " & ex.Message)
        End Try

    End Sub


    Private Function ValidateValue(ByVal value As String) As String
        If String.IsNullOrEmpty(value) Then
            Return Nothing
        Else
            Return value.Trim
        End If
    End Function



End Class

