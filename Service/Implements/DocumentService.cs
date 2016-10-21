using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;
using Model;

namespace Service.Implements
{
    class DocumentService : BaseService, IDocumentService
    {
        public DocumentService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public async Task<tblIndexDocument> getDocument(string sKeyAutoID)
        {
            var doc = HongLienDb.tblIndexDocuments.FindAsync(sKeyAutoID);
            return await doc;
        }

        public IQueryable<tblIndexDocument> getDocuments(DateTime dtFrom, DateTime dtTo)
        {
            var doc = from d in HongLienDb.tblIndexDocuments
                      where d.DocumentDate >= dtFrom && d.DocumentDate <= dtTo
                      select d;
            return doc;
        }

        public async Task<bool> saveDocument(bool isAdd, tblIndexDocument doc)
        {
            bool bFlag = false;
            int iKQ = -1;
            if(isAdd)//thêm
            {
                HongLienDb.tblIndexDocuments.Add(doc);
            }
            else //sửa
            {
                tblIndexDocument editDoc = await HongLienDb.tblIndexDocuments.FindAsync(doc.KeyAutoID);
                if (editDoc != null)
                {
                    HongLienDb.Entry(editDoc).CurrentValues.SetValues(doc);
                }
            }
            iKQ = await HongLienDb.SaveChangesAsync();
            if (iKQ < 0)
                bFlag = false;
            else
                bFlag = true;
            return bFlag;
        }

        public async Task<bool> delDocument(string sKeyAutoID)
        {
            bool bFlag = false;
            int iKQ = -1;
            tblIndexDocument delDoc = await HongLienDb.tblIndexDocuments.FindAsync(sKeyAutoID);
            if (delDoc != null)
            {
                HongLienDb.tblIndexDocuments.Remove(delDoc);
            }
            iKQ = await HongLienDb.SaveChangesAsync();
            if (iKQ < 0)
                bFlag = false;
            else
                bFlag = true;
            return bFlag;
        }
    }

}
