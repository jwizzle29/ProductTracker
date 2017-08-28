using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.ViewModels
{
    public class MainVM : ViewModelBase
    {
        private ProductsVM _ProductsVM;
        private KeywordHistoryVM _KeywordHistoryVM;
        private PortalViewVM _PortalViewVM;
        private SQLiteConnection sqliteConnection;
        private int _SelectedIndex;

        public MainVM()
        {
            //BuildTable();
            Initialize();
        }

        public ProductsVM ProductsVM { get { return _ProductsVM; } }

        public KeywordHistoryVM KeywordHistoryVM { get { return _KeywordHistoryVM; } }

        public PortalViewVM PortalViewVM { get { return _PortalViewVM; } }

        public void Initialize()
        {
            _ProductsVM = new ProductsVM();
            AddChildVM(_ProductsVM);
        }

        public int SelectedIndex
        {
            get
            {
                return _SelectedIndex;
            }
            set
            {
                if (_SelectedIndex == value)
                    return;

                _SelectedIndex = value;
                RaisePropertyChanged(nameof(SelectedIndex));
                switch (_SelectedIndex)
                {
                    case 1:
                        if (_ProductsVM.SelectedProduct == null)
                            break;
                        _PortalViewVM = new PortalViewVM(_ProductsVM.SelectedProduct);
                        AddChildVM(_PortalViewVM);
                        RaisePropertyChanged(nameof(PortalViewVM));
                        break;

                    case 2:
                        if (_ProductsVM.SelectedProduct == null)
                            break;
                        _KeywordHistoryVM = new KeywordHistoryVM(_ProductsVM.SelectedProduct, _ProductsVM.SelectedProduct.Product.Keyword);
                        AddChildVM(_KeywordHistoryVM);
                        RaisePropertyChanged(nameof(KeywordHistoryVM));                      
                        break;

                    case 3:
                        //Product History Tab                      
                        break;

                }
            }
        }

        public void SaveIntoDataContext()
        {
            try
            {
                SessionDataContext.SaveChanges();
            }
            catch (Exception e)
            {

            }
        }
    }
}
