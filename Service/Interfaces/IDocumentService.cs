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
        object getDocument(string sKeyAutoID);
        object getDocuments(DateTime dtFrom, DateTime dtTo, string sDocType);
        Task<bool> saveDocument(bool isAdd, tblIndexDocument doc);
        Task<bool> delDocument(string sKeyAutoID);
    }
}
