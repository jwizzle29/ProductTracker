using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.ViewModels
{
    public class PortalViewItemVM : ViewModelBase
    {
        private ProductHistory _ProductHistory;
        public PortalViewItemVM(ViewModelSession vmSession, ProductHistory productHistory)
        {
            _ProductHistory = productHistory;
        }

        public int ProductId
        {
            get { return _ProductHistory.ProductId; }
            set
            {
                if (_ProductHistory.ProductId == value)
                    return;

                _ProductHistory.ProductId = value;
                RaisePropertyChanged(nameof(ProductId));
            }
        }

        public string Portal
        {
            get { return _ProductHistory.Portal; }
            set
            {
                if (_ProductHistory.Portal == value)
                    return;

                _ProductHistory.Portal = value;
                RaisePropertyChanged(nameof(Portal));
            }
        }

        public string ProductName
        {
            get { return _ProductHistory.ProductName; }
            set
            {
                if (_ProductHistory.ProductName == value)
                    return;

                _ProductHistory.ProductName = value;
                RaisePropertyChanged(nameof(ProductName));
            }
        }

        public DateTime? DateModified
        {
            get { return _ProductHistory.DateModified; }
            set
            {
                if (_ProductHistory.DateModified == value)
                    return;

                _ProductHistory.DateModified = value;
                RaisePropertyChanged(nameof(DateModified));
            }
        }

        public string Keyword
        {
            get { return _ProductHistory.Keyword; }
            set
            {
                if (_ProductHistory.Keyword == value)
                    return;

                _ProductHistory.Keyword = value;
                RaisePropertyChanged(nameof(Keyword));
            }
        }

        public int? Rank
        {
            get { return _ProductHistory.Rank; }
            set
            {
                if (_ProductHistory.Rank == value)
                    return;

                _ProductHistory.Rank = value;
                RaisePropertyChanged(nameof(Rank));
            }
        }

        public string Review
        {
            get { return _ProductHistory.Review; }
            set
            {
                if (_ProductHistory.Review == value)
                    return;

                _ProductHistory.Review = value;
                RaisePropertyChanged(nameof(Review));
            }
        }

        public string Note
        {
            get { return _ProductHistory.Note; }
            set
            {
                if (_ProductHistory.Note == value)
                    return;

                _ProductHistory.Note = value;
                RaisePropertyChanged(nameof(Note));
            }
        }
    }
}
