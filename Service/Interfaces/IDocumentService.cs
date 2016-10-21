using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IDocumentService
    {
        Task<tblIndexDocument> getDocument(string sKeyAutoID);
        IQueryable<tblIndexDocument> getDocuments(DateTime dtFrom, DateTime dtTo);
        Task<bool> saveDocument(bool isAdd, tblIndexDocument doc);
        Task<bool> delDocument(string sKeyAutoID);
    }
}
