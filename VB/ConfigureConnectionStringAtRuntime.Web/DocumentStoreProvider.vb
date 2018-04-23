Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing.Service.Extensions
Imports DevExpress.Xpo.DB
Imports System.ComponentModel.Composition

Namespace ConfigureConnectionStringAtRuntime.Web
	<Export(GetType(IDocumentStoreProvider))> _
	Public Class DocumentStoreProvider
		Implements IDocumentStoreProvider
		#Region "IDocumentStoreProvider Members"

        Public ReadOnly Property ConnectionString() As String Implements IDocumentStoreProvider.ConnectionString
            Get
                Return AccessConnectionProvider.GetConnectionString("|DataDirectory|/ReportService.mdb")
            End Get
        End Property

        Public ReadOnly Property KeepInterval() As TimeSpan Implements IDocumentStoreProvider.KeepInterval
            Get
                Return TimeSpan.FromHours(24)
            End Get
        End Property

		#End Region
	End Class
End Namespace