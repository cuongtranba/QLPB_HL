using _4.Helper;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using LinqKit;

namespace Service.Implements
{
    public class InOutReasonCategoryService : BaseService, ICategoryService
    {
        public InOutReasonCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }

        private IQueryable<InOutReasonViewModel> BaseInOutReasonQuery()
        {
            return from p1 in HongLienDb.tblIndexInOutReasons.AsNoTracking().AsExpandable()
                   join p2 in HongLienDb.tblIndexAccounts.AsNoTracking().AsExpandable() on p1.Acc equals p2.KeyAutoID into
                   account
                   from p2 in account.DefaultIfEmpty()
                   join p3 in HongLienDb.tblIndexAccounts.AsNoTracking().AsExpandable() on p1.Acc1 equals p3.KeyAutoID into
                   account1
                   from p3 in account1.DefaultIfEmpty()
                   join p4 in HongLienDb.tblIndexAccounts.AsNoTracking().AsExpandable() on p1.Acc2 equals p4.KeyAutoID into
                   account2
                   from p4 in account2.DefaultIfEmpty()
                   where p1.IsDeleted == false
                   select new InOutReasonViewModel()
                   {
                       KeyAutoID = p1.KeyAutoID,
                       ReasonID = p1.ReasonID,
                       ReasonDesc = p1.ReasonDesc,
                       DocType = p1.DocType,
                       Acc = p1.Acc,
                       AccountName = p2.AccountDesc,
                       Acc1 = p1.Acc1,
                       AccountName1 = p3.AccountDesc,
                       Acc2 = p1.Acc2,
                       AccountName2 = p4.AccountDesc,
                       Note = p1.Note
                   };
        }
        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReasonDesc", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên lí do", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "DocType", Size = new Size(199, 20),DataSource = GetDocTypes(),DropDownStyle = ComboBoxStyle.DropDownList},
                Label = new Label() {Text = "Loại phiếu", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "Acc", Size = new Size(199, 20),AutoCompleteSource = AutoCompleteSource.ListItems,AutoCompleteMode = AutoCompleteMode.Suggest,DataSource = GetUsers()},
                Label = new Label() {Text = "Tên tài khoản", TextAlign = ContentAlignment.MiddleLeft}
            },
        };

        private object GetUsers()
        {
            var model = HongLienDb.tblIndexAccounts.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new ComboboxItem()
                    {
                        Text = c.AccountDesc,
                        Value = c.KeyAutoID
                    }).ToList();
            model.Insert(0,ComboboxItem.Empty);
            return model;
        }

        private object GetDocTypes()
        {
            return new List<ComboboxItem>()
            {
                ComboboxItem.Empty,
                new ComboboxItem()
                {
                    Text = "Phiếu nhập",
                    Value = "PN"
                },
                new ComboboxItem()
                {
                    Text = "Phiếu xuất",
                    Value = "PX"
                }
            };
        }

        public object GetDataSource()
        {
            return BaseInOutReasonQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchInOutReasonViewModel = controls.ToModel<SearchInOutReasonViewModel>();
            var query = BaseInOutReasonQuery();
            if (!string.IsNullOrEmpty(searchInOutReasonViewModel.Acc))
            {
                query =
                    query.Where(
                        c =>
                            c.Acc.Contains(searchInOutReasonViewModel.Acc) ||
                            c.Acc1.Contains(searchInOutReasonViewModel.Acc) ||
                            c.Acc2.Contains(searchInOutReasonViewModel.Acc));
            }
            if (!string.IsNullOrEmpty(searchInOutReasonViewModel.DocType))
            {
                query = query.Where(c => c.DocType.Contains(searchInOutReasonViewModel.DocType));
            }
            if (!string.IsNullOrEmpty(searchInOutReasonViewModel.ReasonDesc))
            {
                query = query.Where(c => c.ReasonDesc.Contains(searchInOutReasonViewModel.ReasonDesc));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {

            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReasonID", Size = new Size(199, 20)},
                Label = new Label() {Text = "Mã lí do", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReasonDesc", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên lí do", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "DocType", Size = new Size(199, 20),DataSource = GetDocTypes(),DropDownStyle = ComboBoxStyle.DropDownList},
                Label = new Label() {Text = "Loại phiếu", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "Acc", Size = new Size(199, 20),AutoCompleteSource = AutoCompleteSource.ListItems,AutoCompleteMode = AutoCompleteMode.Suggest,DataSource = GetUsers()},
                Label = new Label() {Text = "Tên tài khoản", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "Acc1", Size = new Size(199, 20),AutoCompleteSource = AutoCompleteSource.ListItems,AutoCompleteMode = AutoCompleteMode.Suggest,DataSource = GetUsers()},
                Label = new Label() {Text = "Tên tài khoản 1", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new ComboBox() {Name = "Acc2", Size = new Size(199, 20),AutoCompleteSource = AutoCompleteSource.ListItems,AutoCompleteMode = AutoCompleteMode.Suggest,DataSource = GetUsers()},
                Label = new Label() {Text = "Tên tài khoản 2", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "Note", Size = new Size(199, 20)},
                Label = new Label() {Text = "Ghi chú", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "KeyAutoID", Size = new Size(199, 20),Visible = false},
                Label = new Label() {Text = "KeyAutoID", TextAlign = ContentAlignment.MiddleLeft,Visible = false}
            },
        };
        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<CreateInOutReasonViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<CreateInOutReasonViewModel, tblIndexInOutReason>(viewModel);
                HongLienDb.tblIndexInOutReasons.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (InOutReasonViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexInOutReason>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<InOutReasonViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateInOutReasonViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateInOutReasonViewModel, tblIndexInOutReason>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
