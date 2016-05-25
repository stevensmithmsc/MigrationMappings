using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationMappingsApp.Entity;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace MigrationMappingsApp.ViewModels
{
    class MainViewModel
    {
        MigrationEntities db;

        public ObservableCollection<RefArea> Areas { get; set; }
        public RefArea SelectedArea { get; set; }

        public MainViewModel()
        {
            db = new MigrationEntities();
            db.RefAreas.Load();
            Areas = db.RefAreas.Local;
            SelectedArea = Areas.First();
        }
    }
}
