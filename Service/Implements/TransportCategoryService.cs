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
    public class TransportCategoryService:BaseService,ICategoryService
    {
        public TransportCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }
        private IQueryable<TransportViewModel> BaseTransQuery()
        {
            return HongLienDb.tblIndexTransports.AsNoTracking().Where(c => c.IsDeleted == false)
                .ProjectTo<TransportViewModel>();
        }

        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "TransID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã phương tiện",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "TransName",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên phương tiện",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "Note",Size = new Size(199,20)},
                        Label = new Label() {Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                    }
        };
        public object GetDataSource()
        {
            return BaseTransQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchModel = controls.ToModel<SearchTransportViewModel>();
            var query = BaseTransQuery();
            if (!string.IsNullOrEmpty(searchModel.Note))
            {
                query = query.Where(c => c.Note.Contains(searchModel.Note));
            }
            if (!string.IsNullOrEmpty(searchModel.TransID))
            {
                query = query.Where(c => c.TransID.Contains(searchModel.TransID));
            }
            if (!string.IsNullOrEmpty(searchModel.TransName))
            {
                query = query.Where(c => c.TransName.Contains(searchModel.TransName));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "TransID",Size = new Size(199,20)},
                        Label = new Label() {Text = "Mã bốc xếp",TextAlign = ContentAlignment.MiddleLeft}
                    },
           new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "TransName",Size = new Size(199,20)},
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
            var viewModel = controls.ToModel<AddTransportViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<AddTransportViewModel, tblIndexTransport>(viewModel);
                HongLienDb.tblIndexTransports.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (TransportViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexTransport>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<LoaderViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateTransportViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateTransportViewModel, tblIndexTransport>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
