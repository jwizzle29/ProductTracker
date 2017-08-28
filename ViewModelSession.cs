using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker
{
    public class ViewModelSession 
    {
        private ProductTrackerDataContext _DataContext = new ProductTrackerDataContext();

        public ViewModelSession()
        {

        }

        public ProductTrackerDataContext DataContext { get { return _DataContext; } }
    }
}
