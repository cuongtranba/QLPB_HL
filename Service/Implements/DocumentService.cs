using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;
using Model;
using _4.Helper;

namespace Service.Implements
{
    class DocumentService : BaseService, IDocumentService
    {
        public DocumentService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery => new StringBuilder("Set dateformat dmy; SELECT tblDoc.KeyAutoID, tblDoc.BranchID, tblDoc.Period, tblDoc.DocumentID, tblDoc.DocumentTypeID, tblDoc.ReasonID, tblReason.ReasonDesc, tblDoc.DocumentDesc, tblDoc.DocumentDate, tblDoc.TransportID, tblTrans.TransName, tblDoc.Distance, tblDoc.ContractNo, tblDoc.ContractDate, tblDoc.TaxGroup, tblDoc.PayMethod, tblDoc.PersonName, tblDoc.ObjectId, tblDoc.ObjectName, tblDoc.CurrencyID, tblDoc.CurrencyExRateVND, tblDoc.CurrencyExRateUSD, tblDoc.StockID, tblDoc.LoaderID, tblDoc.LoaderPrice, tblDoc.TaxRate, tblDoc.TotalAmount, tblDoc.TotalAmountVND, tblDoc.TotalAmountUSD, tblDoc.VATable, tblDoc.VATableVND, tblDoc.VATableUSD, tblDoc.VATAmount, tblDoc.VATAmountVND, tblDoc.VATAmountUSD, tblDoc.TotalMoney, tblDoc.TotalMoneyVND, tblDoc.TotalMoneyUSD, tblDoc.InWords, tblDoc.InWordsVND, tblDoc.InWordsUSD, tblDoc.Note, tblDoc.isLock, tblDoc.CreateBy, tblDoc.CreateDate, tblDoc.EditBy, tblDoc.EditDate, tblDoc.IsDeleted, tblStock.StockDesc, tblLoad.LoaderName FROM tblIndexDocument AS tblDoc LEFT OUTER JOIN tblIndexLoader AS tblLoad ON tblDoc.LoaderID = tblLoad.KeyAutoID LEFT OUTER JOIN tblIndexStock AS tblStock ON tblDoc.StockID = tblStock.KeyAutoID LEFT OUTER JOIN tblIndexInOutReason AS tblReason ON tblDoc.ReasonID = tblReason.KeyAutoID LEFT OUTER JOIN tblIndexTransport AS tblTrans ON tblDoc.TransportID = tblTrans.KeyAutoID WHERE tblDoc.IsDeleted = 'false'");

        public object getDocument(string sKeyAutoID)
        {
            var strQuery = BaseQuery.Append(" AND KeyAutoID = '" + sKeyAutoID + "'");
            var doc = HongLienDb.Database.SqlQuery<Model.ViewModel.DocumentViewModel>(BaseQuery.ToString()).ToList().ToSortableBindingList();
            //var doc = HongLienDb.tblIndexDocuments.FindAsync(sKeyAutoID);
            return doc;
        }

        public object getDocuments(DateTime dtFrom, DateTime dtTo, string sDocType)
        {
            var strQuery = BaseQuery.Append(" AND DocumentDate >= '" + dtFrom.ToString("dd/MM/yyyy") + "' AND DocumentDate <= '" + dtTo.ToString("dd/MM/yyyy") + "' AND DocumentTypeID = '" + sDocType + "'");
            var doc = HongLienDb.Database.SqlQuery<Model.ViewModel.DocumentViewModel>(strQuery.ToString()).ToList().ToSortableBindingList();
            //var doc = from d in HongLienDb.tblIndexDocuments
            //          where d.DocumentDate >= dtFrom && d.DocumentDate <= dtTo
            //          select d;
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
            var bFlag = false;
            var iKq = -1;
            var delDoc = await HongLienDb.tblIndexDocuments.FindAsync(sKeyAutoID);
            if (delDoc != null)
            {
                HongLienDb.tblIndexDocuments.Remove(delDoc);
            }
            iKq = await HongLienDb.SaveChangesAsync();
            bFlag = iKq >= 0;
            return bFlag;
        }
    }

}
