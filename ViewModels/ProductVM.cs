using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProductTracker.ViewModels
{
    public class ProductVM : ViewModelBase
    {
        private Product _Product;
        private ProductTrackerDataContext _DataContext;

        public ProductVM(ViewModelSession vmSession, Product product)
        {
            _Product = product;
        }

        public event EventHandler KeywordChanged;

        protected virtual void OnKeywordChange(PropertyChangedEventArgs e)
        {
            KeywordChanged?.Invoke(this, e);
        }

        public Product Product
        {
            get { return _Product; }
        }

        private string _Portal;
        public string Portal
        {
            get
            {
                return _Product.Portal;
            }
            set
            {
                if (_Product.Portal == value)
                    return;

                _Product.Portal = value;
                RaisePropertyChanged(nameof(Portal));
            }
        }

        private string _ProductName;
        public string ProductName
        {
            get { return _Product.ProductName; }
            set
            {
                if (_Product.ProductName == value)
                    return;
                _Product.ProductName = value;
                RaisePropertyChanged(nameof(ProductName));
            }
        }

        private string _Keyword;
        public string Keyword
        {
            get { return _Product.Keyword; }
            set
            {
                if (_Product.Keyword == value)
                    return;

                _Product.Keyword = value;
                RaisePropertyChanged(nameof(Keyword));
                OnKeywordChange(new PropertyChangedEventArgs(nameof(Keyword)));
            }
        }

        private string _Category;
        public string Category
        {
            get { return _Product.Category; }
            set
            {
                if (_Product.Category == value)
                    return;
                _Product.Category = value;
                RaisePropertyChanged(nameof(Category));
            }
        }

        private int? _Rank;
        public int? Rank
        {
            get { return _Product.Rank; }
            set
            {
                if (_Product.Rank == value.GetValueOrDefault())
                    return;
                _Product.Rank = value.GetValueOrDefault();
                RaisePropertyChanged(nameof(Rank));
            }
        }

        private decimal? _ReviewCount;
        public decimal? ReviewCount
        {
            get { return _Product.ReviewCount; }
            set
            {
                if (_Product.ReviewCount == value.GetValueOrDefault())
                    return;
                _Product.ReviewCount = value.GetValueOrDefault();
                RaisePropertyChanged(nameof(ReviewCount));
            }
        }

        private DateTime? _EntryDate;
        public DateTime? EntryDate
        {
            get { return _Product.EntryDate; }
            set
            {
                if (_Product.EntryDate == value)
                    return;

                _Product.EntryDate = value;
                RaisePropertyChanged(nameof(EntryDate));
            }
        }

        private string _Description;
        public string Description
        {
            get { return _Product.Description; }
            set
            {
                if (_Product.Description == value)
                    return;
                _Product.Description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }
    }
}
