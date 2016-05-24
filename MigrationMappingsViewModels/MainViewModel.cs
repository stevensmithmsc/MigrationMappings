using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MigrationMappings;
using System.Collections.ObjectModel;

namespace MigrationMappingsViewModels
{
    public class MainViewModel
    {
        MappingsDBContext db;
        ObservableCollection<RefArea> Areas { get; set; }

        public MainViewModel()
        {
            db = new MappingsDBContext();
            db.RefAreas.Load();
            Areas = db.RefAreas.Local;
        }
    }
}
