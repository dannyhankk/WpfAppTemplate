using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfAppTemplate.Models;

namespace WpfAppTemplate.ViewModels
{
    public class TemplateCategoryViewModel : Screen
    {
        private TemplateCategoryModel _selectCategoryModel = new(){Name="Category1", Description="for test"};

        public string CategoryName
        {
            get => _selectCategoryModel.Name;
            set
            {
                _selectCategoryModel.Name = value;
                NotifyOfPropertyChange(CategoryName);
                NotifyOfPropertyChange(() => CanEdit);
            }
        }

        public string? CategoryDescription
        {
            get => _selectCategoryModel.Description;
            set
            {
                _selectCategoryModel.Description = value;
                NotifyOfPropertyChange(CategoryDescription);
            }

        }

        public bool CanEdit
        {
            get
            {
                return _selectCategoryModel.Name.Length > 2;
            }
        }

        public void Edit()
        {
            MessageBox.Show(_selectCategoryModel.Name);
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }
    }
}
