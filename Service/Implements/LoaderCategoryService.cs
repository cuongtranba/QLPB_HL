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
    public class LoaderCategoryService : BaseService, ICategoryService
    {
        public LoaderCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }
        
        public StringBuilder BaseQuery { get; }

        private IQueryable<LoaderViewModel> BaseLoaderQuery()
        {
            return HongLienDb.tblIndexLoaders.AsNoTracking().Where(c => c.IsDeleted == false)
                .ProjectTo<LoaderViewModel>();
        }
        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "LoaderID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã bốc xếp",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "LoaderName",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên bốc xếp",TextAlign = ContentAlignment.MiddleLeft}
                    }
        };

        public object GetDataSource()
        {
            return BaseLoaderQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchModel = controls.ToModel<SearchLoaderViewModel>();
            var query = BaseLoaderQuery();
            if (!string.IsNullOrEmpty(searchModel.LoaderID))
            {
                query = query.Where(c => c.LoaderID.Contains(searchModel.LoaderID));
            }
            if (!string.IsNullOrEmpty(searchModel.LoaderName))
            {
                query = query.Where(c => c.LoaderName.Contains(searchModel.LoaderID));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "LoaderID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã bốc xếp",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "LoaderName",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên bốc xếp",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new RichTextBox(){Name = "Note",Size = new Size(199,100)},
                        Label = new Label(){Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "KeyAutoID",Size = new Size(199,20),Visible = false},
                        Label = new Label() {Text = "KeyAutoID",TextAlign = ContentAlignment.MiddleLeft,Visible = false}
                    },
        };
        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<AddLoaderViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<AddLoaderViewModel, tblIndexLoader>(viewModel);
                HongLienDb.tblIndexLoaders.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (LoaderViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexLoader>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<LoaderViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateLoaderViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateLoaderViewModel, tblIndexLoader>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
