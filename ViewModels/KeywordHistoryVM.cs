using ProductTracker.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductTracker.ViewModels
{
    public class KeywordHistoryVM : ViewModelBase
    {
        private ProductVM _ProductVM;
        private ObservableCollection<KeywordHistory> _Keywords = new ObservableCollection<KeywordHistory>();
        private string _Keyword;

        public KeywordHistoryVM(ProductVM productVM, string keyword)
        {
            _Keyword = keyword;
            _ProductVM = productVM;
            AddInitialKeywordHistoryRecord(_ProductVM.Product.Keyword);
            LoadHistoriesByKeyword();

            _ProductVM.PropertyChanged += OnKeywordChanged;
        }

        private void CheckIfKeywordExists()
        {

        }

        void OnKeywordChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Keyword")
            {
                AddKeyword(_ProductVM.Product.Keyword);
            }
            _ProductVM.PropertyChanged -= OnKeywordChanged;
        }

        public ProductVM Product { get { return _ProductVM; } }
        public ObservableCollection<KeywordHistory> Keywords { get { return _Keywords; } }
        private void LoadHistoriesByKeyword()
        {
            var keywordHistories = SessionDataContext
                .KeywordHistories
                .Where(x => x.ProductId == _ProductVM.Product.ProductId);

            foreach (var history in keywordHistories)
            {
                _Keywords.Add(history);
            }
            RaisePropertyChanged(nameof(Keywords));
        }

        public void AddKeyword(string keyword)
        {
            KeywordHistory keywordHistory = new KeywordHistory();
            keywordHistory.DateModified = DateTime.Now;
            keywordHistory.Keyword = keyword;
            keywordHistory.ProductId = _ProductVM.Product.ProductId;

            SessionDataContext.KeywordHistories.Add(keywordHistory);
            SessionDataContext.SaveChanges();
        }

        public void AddInitialKeywordHistoryRecord(string keyword)
        {
            var keywordHistories = SessionDataContext
                .KeywordHistories
                .Where(x => x.ProductId == _ProductVM.Product.ProductId);

            if (keywordHistories.Count() != 0)
                return;

            KeywordHistory keywordHistory = new KeywordHistory();
            keywordHistory.DateModified = DateTime.Now;
            keywordHistory.Keyword = keyword;
            keywordHistory.ProductId = _ProductVM.Product.ProductId;

            SessionDataContext.KeywordHistories.Add(keywordHistory);
            SessionDataContext.SaveChanges();
        }
    }
}
