using System;
using System.ComponentModel.Composition;
using DevExpress.Xpf.Printing.Service.Extensions;
using DevExpress.Xpo.DB;

namespace ConfigureConnectionStringAtRuntime.Web {
    [Export(typeof(IDocumentDataStorageProvider))]
    public class DocumentDataStorageProvider : IDocumentDataStorageProvider {
        #region IDocumentStoreProvider Members

        string IDocumentDataStorageProvider.ConnectionString {
            get { return AccessConnectionProvider.GetConnectionString("|DataDirectory|/ReportService.mdb"); }
        }

        TimeSpan IDocumentDataStorageProvider.KeepInterval {
            get { return this.GetDefaultKeepInterval(); }
        }

        int IDocumentDataStorageProvider.BinaryStorageChunkSize {
            get { return this.GetDefaultBinaryStorageChunkSize(); }
        }

        #endregion
    }
}