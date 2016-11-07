using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using LinqKit;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class FeeCategoryService : BaseService, ICategoryService
    {
        public FeeCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }

        private IQueryable<FeeViewModel> BaseFeeQuery()
        {
            return from fee in HongLienDb.tblIndexFees.AsNoTracking().AsExpandable()
                   join feeGroup in HongLienDb.tblIndexFeeGroups.AsNoTracking().AsExpandable() on fee.FeeGroupID equals feeGroup.KeyAutoID into f
                   from f2 in f.DefaultIfEmpty()
                   where fee.IsDeleted == false
                   select new FeeViewModel()
                   {
                       KeyAutoID = fee.KeyAutoID,
                       FeeID = fee.FeeID,
                       FeeGroupID = fee.FeeGroupID,
                       FeeDesc = fee.FeeDesc,
                       Note = fee.Note,
                       GroupName = f2.FeeGroupDesc
                   };
        }
        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "FeeDesc",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên chi phí",TextAlign = ContentAlignment.MiddleLeft}
                    },
            new ControlViewModel()
                    {
                        Control = new ComboBox(){Name = "FeeGroupID",Size = new Size(199,20),DataSource = GetFeeGroup(),DropDownStyle = ComboBoxStyle.DropDownList},
                        Label = new Label() {Text = "Tên nhóm",TextAlign = ContentAlignment.MiddleLeft}
                    },
        };

        private List<ComboboxItem> GetFeeGroup()
        {
            var model =
                HongLienDb.tblIndexFeeGroups.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new ComboboxItem()
                    {
                        Text = c.FeeGroupDesc,
                        Value = c.KeyAutoID
                    })
                    .ToList();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }

        public object GetDataSource()
        {
            return BaseFeeQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchViewModel = controls.ToModel<SearchFeeViewModel>();
            var query = BaseFeeQuery();
            if (!string.IsNullOrEmpty(searchViewModel.FeeGroupID))
            {
                query = query.Where(c => c.FeeGroupID.Contains(searchViewModel.FeeGroupID));
            }
            if (!string.IsNullOrEmpty(searchViewModel.FeeDesc))
            {
                query = query.Where(c => c.FeeDesc.Contains(searchViewModel.FeeDesc));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "KeyAutoID",Size = new Size(199,20),Visible = false},
                        Label = new Label() {Text = "KeyAutoID",TextAlign = ContentAlignment.MiddleLeft,Visible = false}
                    },
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "FeeID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã chi phí",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                       Control = new ComboBox(){Name = "FeeGroupID",Size = new Size(199,20),DataSource = GetFeeGroup(),DropDownStyle = ComboBoxStyle.DropDownList},
                        Label = new Label() {Text = "Tên nhóm",TextAlign = ContentAlignment.MiddleLeft}
                    },
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "FeeDesc",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên chi phí",TextAlign = ContentAlignment.MiddleLeft}
                    },
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "Note",Size = new Size(199,20)},
                        Label = new Label() {Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                    },
        };
        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<CreateFeeViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<CreateFeeViewModel, tblIndexFee>(viewModel);
                HongLienDb.tblIndexFees.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (FeeViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexFee>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<FeeViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateFeeViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateFeeViewModel, tblIndexFee>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
