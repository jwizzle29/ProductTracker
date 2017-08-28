using ProductTracker.DataModel;
using ProductTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker
{
    public class DbHelper
    {
        private ProductTrackerDataContext _SessionDataContext;
        private ProductVM _ProductVM;

        public DbHelper(ProductTrackerDataContext sessionDataContext, ProductVM productVM)
        {
            _ProductVM = productVM;
            _SessionDataContext = sessionDataContext;

            _ProductVM.PropertyChanged += OnKeywordChanged;
        }

        void OnKeywordChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Keyword")
            {
                AddIntoKeywordHistory(_ProductVM.Product.Keyword);
            }
        }

        void Keyword_KeywordChanged(object sender, EventArgs e)
        {      
            AddIntoKeywordHistory(_ProductVM.Product.Keyword);
        }

        public void AddIntoKeywordHistory(string keyword)
        {
            KeywordHistory keywordHistory = new KeywordHistory();
            keywordHistory.DateModified = DateTime.Now;
            keywordHistory.Keyword = keyword;
            keywordHistory.ProductId = _ProductVM.Product.ProductId;
            _SessionDataContext.KeywordHistories.Add(keywordHistory);

            _SessionDataContext.SaveChanges();
        }
    }
}
