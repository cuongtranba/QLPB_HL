using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
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
    public class CustomerCategoryService : BaseService, ICategoryService
    {
        public CustomerCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }

        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ObjectName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên khách hàng", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "RepresentativeName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên đại diện", TextAlign = ContentAlignment.MiddleLeft}
            },
        };

        private IQueryable<ObjectViewModel> BaseObjectQuery()
        {
            return
                HongLienDb.tblIndexObjects.AsNoTracking().Where(c => c.IsDeleted == false).ProjectTo<ObjectViewModel>();
        }

        public object GetDataSource()
        {
            return BaseObjectQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchModel = controls.ToModel<SearchObjectViewModel>();
            var query = BaseObjectQuery();
            if (!string.IsNullOrEmpty(searchModel.ObjectName))
            {
                query = query.Where(c => c.ObjectName.Contains(searchModel.ObjectName));
            }
            if (!string.IsNullOrEmpty(searchModel.RepresentativeName))
            {
                query = query.Where(c => c.RepresentativeName.Contains(searchModel.RepresentativeName));
            }
            return query.ToList().ToSortableBindingList();
        }

        public List<ControlViewModel> GetCRUDComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "KeyAutoID", Size = new Size(199, 20), Visible = false},
                Label = new Label() {Text = "KeyAutoID", TextAlign = ContentAlignment.MiddleLeft, Visible = false}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ObjectID", Size = new Size(199, 20)},
                Label = new Label() {Text = "Mã khách hàng", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ObjectName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên khách hàng", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "AbbName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên viết tắt", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ObjectAddress", Size = new Size(199, 20)},
                Label = new Label() {Text = "Địa chỉ", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "TaxCode", Size = new Size(199, 20)},
                Label = new Label() {Text = "Số thuế", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "BankCode", Size = new Size(199, 20)},
                Label = new Label() {Text = "Số ngân hàng", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "PhoneNum", Size = new Size(199, 20)},
                Label = new Label() {Text = "Điện thoại", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "Email", Size = new Size(199, 20)},
                Label = new Label() {Text = "Email", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "Website", Size = new Size(199, 20)},
                Label = new Label() {Text = "Website", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "Fax", Size = new Size(199, 20)},
                Label = new Label() {Text = "Fax", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "RepresentativeName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên người đại diện", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReprPhone", Size = new Size(199, 20)},
                Label = new Label() {Text = "Đt người đại diện", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReprAdd", Size = new Size(199, 20)},
                Label = new Label() {Text = "Địa chỉ người đại diện", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "ReprEmail", Size = new Size(199, 20)},
                Label = new Label() {Text = "Email người đại diện", TextAlign = ContentAlignment.MiddleLeft}
            },
            new ControlViewModel()
            {
                Control = new TextBox() {Name = "DirectorName", Size = new Size(199, 20)},
                Label = new Label() {Text = "Tên giám đốc", TextAlign = ContentAlignment.MiddleLeft}
            },

        };

        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<CreateObjectViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<CreateObjectViewModel, tblIndexObject>(viewModel);
                HongLienDb.tblIndexObjects.Add(model);
                try
                {
                    HongLienDb.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (ObjectViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexObject>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<ObjectViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<UpdateObjectViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<UpdateObjectViewModel, tblIndexObject>(viewModel);
                base.Update(model);
            }
            return modelState;
        }
    }
}
