using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.ViewModels
{
    public class ApplicationVM : ViewModelBase
    {
        private SQLiteConnection sqliteConnection;

        public void Startup()
        {
            sqliteConnection = new SQLiteConnection();
            SQLWorker sqlWorker = new SQLWorker(sqliteConnection);
            sqlWorker.Initialize();
            sqlWorker.Open();
            sqlWorker.CreateProductTable();
            sqlWorker.CreateProductHistoryTable();
            sqlWorker.CreateKeywordHistoryTable();
            CreateMainViewModel();
        }

        public MainVM CreateMainViewModel()
        {
            MainVM mainVM = new MainVM();
            AddChildVM(mainVM);
            return mainVM;
        }
    }
}
