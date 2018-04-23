using System;
using System.ComponentModel.Composition;
using DevExpress.Xpf.Printing.Service.Extensions;
using DevExpress.Xpo.DB;

namespace ConfigureConnectionStringAtRuntime.Web {
    [Export(typeof(IDocumentStoreProvider))]
    public class DocumentStoreProvider : IDocumentStoreProvider {
        #region IDocumentStoreProvider Members

        string IDocumentStoreProvider.ConnectionString {
            get { return AccessConnectionProvider.GetConnectionString("|DataDirectory|/ReportService.mdb"); }
        }

        TimeSpan IDocumentStoreProvider.KeepInterval {
            get { return TimeSpan.FromHours(24); }
        }

        #endregion
    }
}