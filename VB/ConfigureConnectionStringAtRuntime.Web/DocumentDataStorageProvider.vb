Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing.Service.Extensions
Imports DevExpress.Xpo.DB
Imports System.ComponentModel.Composition

Namespace ConfigureConnectionStringAtRuntime.Web
    <Export(GetType(IDocumentDataStorageProvider))> _
    Public Class DocumentDataStorageProvider
        Implements IDocumentDataStorageProvider
#Region "IDocumentStoreProvider Members"

        Public ReadOnly Property ConnectionString() As String Implements IDocumentDataStorageProvider.ConnectionString
            Get
                Return AccessConnectionProvider.GetConnectionString("|DataDirectory|/ReportService.mdb")
            End Get
        End Property

        Public ReadOnly Property KeepInterval() As TimeSpan Implements IDocumentDataStorageProvider.KeepInterval
            Get
                Return Me.GetDefaultKeepInterval()
            End Get
        End Property

        Public ReadOnly Property BinaryStorageChunkSize() As Integer Implements IDocumentDataStorageProvider.BinaryStorageChunkSize
            Get
                Return Me.GetDefaultBinaryStorageChunkSize()
            End Get
        End Property
#End Region
    End Class
End Namespace