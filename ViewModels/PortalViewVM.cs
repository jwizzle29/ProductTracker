using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.ViewModels
{
    public class PortalViewVM : ViewModelBase
    {
        private ObservableCollection<PortalViewItemVM> _PortalViewItems = new ObservableCollection<PortalViewItemVM>();

        private PortalViewItemVM _SelectedProduct;
        private string _Keyword, _ProductName;

        public PortalViewVM(ProductVM productVM)
        {
            _ProductName = productVM.Product.ProductName;
            _Keyword = productVM.Product.Keyword;
            LoadPortalView();
        }

        public ObservableCollection<PortalViewItemVM> PortalViewItems { get { return _PortalViewItems; } }

        private void LoadPortalView()
        {
            var products = SessionDataContext.Products
                .Where(x => x.Keyword == _Keyword && x.ProductName == _ProductName);

            foreach(var product in products)
            {
                ProductHistory pH = new ProductHistory();
                pH.Keyword = product.Keyword;
                pH.Note = (_SelectedProduct == null) ? string.Empty : _SelectedProduct.Note;
                pH.Portal = product.Portal;
                pH.ProductId = product.ProductId;
                pH.ProductName = product.ProductName;
                pH.Rank = product.Rank;
                pH.Review = (_SelectedProduct == null) ? string.Empty : _SelectedProduct.Review;
                var itemVM = new PortalViewItemVM(VMSession, pH);
                _PortalViewItems.Add(itemVM);
                AddChildVM(itemVM);
            }
        }

        public PortalViewItemVM SelectedProduct
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
    }
}
