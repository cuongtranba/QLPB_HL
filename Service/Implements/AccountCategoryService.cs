using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class AccountCategoryService:BaseService,ICategoryService
    {
        public AccountCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }

        private IQueryable<AccountViewModel> BaseAccountQuery()
        {
            return HongLienDb.tblIndexAccounts.Where(c => c.IsDeleted == false).ProjectTo<AccountViewModel>();
        }

        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
             new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "AccountDesc",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên tài khoản",TextAlign = ContentAlignment.MiddleLeft}
                    },
        };
        public object GetDataSource()
        {
            return BaseAccountQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchViewModel = controls.ToModel<SearchAccountViewModel>();
            var query = BaseAccountQuery();
            if (!string.IsNullOrEmpty(searchViewModel.AccountDesc))
            {
                query = query.Where(c => c.AccountDesc.Contains(searchViewModel.AccountDesc));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {
             new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "AccountID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã tài khoản",TextAlign = ContentAlignment.MiddleLeft}
                    },
              new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "AccountDesc",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên tài khoản",TextAlign = ContentAlignment.MiddleLeft}
                    },
               new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "Note",Size = new Size(199,20)},
                        Label = new Label() {Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                    },
               new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "KeyAutoID",Size = new Size(199,20),Visible = false},
                        Label = new Label() {Text = "KeyAutoID",TextAlign = ContentAlignment.MiddleLeft,Visible = false}
                    },
        };
        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<AddAccountViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<AddAccountViewModel, tblIndexAccount>(viewModel);
                HongLienDb.tblIndexAccounts.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (AccountViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexAccount>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<AccountViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateAccountViewMode>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateAccountViewMode, tblIndexAccount>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
