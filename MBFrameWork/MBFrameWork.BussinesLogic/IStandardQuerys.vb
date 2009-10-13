Public Interface IStandardQuerys

    Function GetTable() As DataTable

    Function GetTable(ByVal mKey As String) As DataTable

    'obtiene la entidad pasada por el Key
    Function GetEntity(ByVal mKey As Object) As Object

    'Obtiene la coleccion de la entidad
    Function GetListOfEntity() As System.Collections.IList

    'Obtiene la colección de la entidad, que se pasa por parámetro la entidad con los objetos seleccionados
    Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList

    'actualiza la entidad que se pasa por parámetro
    Function UpdateEntity(ByVal mEntityObject As Object) As Boolean

    ''' <summary>
    ''' Elimina la entidad 
    ''' </summary>
    ''' <param name="mKey">clave primaria correspondiente a la entidad</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteEntity(ByVal mKey As String) As Boolean

    ''' <summary>
    ''' Elimina la entidad
    ''' </summary>
    ''' <param name="mEntityObject">Entidad que contiene los valores que corresponden al filtrado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function DeleteEntity(ByVal mEntityObject As Object) As Boolean





End Interface
