using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker
{
    public class ViewModelBase : GlobalEventHandler
    {
        private ViewModelSession _ViewModelSession;

        private ViewModelBase _ParentVM;

        private ViewModelBase ParentVM { get { return _ParentVM; } }

        private List<ViewModelBase> _ChildrenVMs = new List<ViewModelBase>();

        private List<ViewModelBase> ChildrenVMs { get { return _ChildrenVMs; } }
       
        public ViewModelBase()
        {
            _ViewModelSession = new ViewModelSession();
        }

        public ViewModelBase(ViewModelSession vmSession)
        {
            _ViewModelSession = vmSession;
        }

        public ViewModelSession VMSession { get { return _ViewModelSession; } }

        public ProductTrackerDataContext SessionDataContext { get { return _ViewModelSession.DataContext; } }

        public void AddChildVM(ViewModelBase childVM)
        {
            childVM._ParentVM = this;
        }


    }
}
