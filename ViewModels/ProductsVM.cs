using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Entity;
namespace ProductTracker.ViewModels
{
    public class ProductsVM : ViewModelBase
    {
        private ObservableCollection<ProductVM> _Products = new ObservableCollection<ProductVM>();
        private ProductVM _SelectedProduct;
        public ProductsVM()
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = SessionDataContext.Products;

            foreach (var product in products)
            {
                var productVM = new ProductVM(VMSession, product);
                _Products.Add(productVM);
                AddChildVM(productVM);
            }
            _SelectedProduct = _Products.FirstOrDefault();
            RaisePropertyChanged(nameof(SelectedProduct));
        }

        public ObservableCollection<ProductVM> Products { get { return _Products; } }

        public ProductVM SelectedProduct
        {
            get { return _SelectedProduct; }
            set
            {
                if (_SelectedProduct == value)
                    return;
                _SelectedProduct = value;
                RaisePropertyChanged(nameof(SelectedProduct));
            }
        }

        #region Commands

        #region Add Command
        private ICommand _AddProductCommand;
        public ICommand AddProductCommand
        {
            get
            {
                if (_AddProductCommand == null)
                    _AddProductCommand = new DelegateCommand(AddProduct);

                return _AddProductCommand;
            }
        }


        private void AddProduct()
        {                 
            Product product = new Product();
            ProductVM productVM = new ProductVM(VMSession, product);
            productVM.EntryDate = DateTime.Now;
            SessionDataContext.Products.Add(product);
            _Products.Add(productVM);
            AddChildVM(productVM);
            _SelectedProduct = productVM;
            RaisePropertyChanged(nameof(Products));
            RaisePropertyChanged(nameof(SelectedProduct));
        }

        #endregion

        #region Save Command
        private ICommand _SaveProductCommand;
        public ICommand SaveProductCommand
        {
            get
            {
                if (_SaveProductCommand == null)
                    _SaveProductCommand = new DelegateCommand(SaveProduct);

                return _SaveProductCommand;
            }
        }

        private void SaveProduct()
        {
            try
            {
                SessionDataContext.SaveChanges();
            }
            catch(Exception e)
            {

            }
        }
        #endregion

        #region Delete Command

        private ICommand _DeleteProductCommand;
        public ICommand DeleteProductCommand
        {
            get
            {
                if (_DeleteProductCommand == null)
                    _DeleteProductCommand = new DelegateCommand(DeleteProduct);

                return _DeleteProductCommand;
            }
        }

        private void DeleteProduct()
        {
            var entry = SessionDataContext.Entry(SelectedProduct.Product);

            if (entry.State == System.Data.Entity.EntityState.Added)
                entry.State = System.Data.Entity.EntityState.Detached;
            else
            {
                SessionDataContext.Products.Remove(SelectedProduct.Product);
                entry.State = EntityState.Deleted;

            }
            
            _Products.Remove(_SelectedProduct);
            SelectedProduct = _Products.FirstOrDefault();
            RaisePropertyChanged(nameof(SelectedProduct));
        }

        #endregion

        #endregion

    }
}
