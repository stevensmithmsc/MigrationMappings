using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationMappingsApp.Entity;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MigrationMappingsApp.ViewModels 
{
    class MainViewModel : INotifyPropertyChanged
    {
        MigrationEntities db;

        public ObservableCollection<RefArea> Areas { get; set; }
        private RefArea _SelectedArea;
        public RefArea SelectedArea { get { return _SelectedArea; } set { _SelectedArea = value; FilterMapsandValues(); NotifyPropertyChanged();  } }
        public List<Map> Mappings { get; set; }
        public List<RefVal> Values { get; set; }
        public bool Changed { get { return db.ChangeTracker.HasChanges(); } }


        public MainViewModel()
        {
            db = new MigrationEntities();
            db.RefAreas.OrderBy(a => a.Area).Load();
            Areas = db.RefAreas.Local;
            SelectedArea = Areas.OrderBy(a => a.ID).First();
            SaveDBChangesCommand = new DelegateCommand<object>(SaveDBChanges);   
        }

        private void FilterMapsandValues()
        {
            db.Maps.Where(m => m.Area == SelectedArea.ID).Load();
            Mappings = db.Maps.Local.Where(m => m.Area == SelectedArea.ID).OrderBy(m => m.Local_Description).ToList();
            NotifyPropertyChanged("Mappings");
            db.RefVals.Where(v => v.Area == SelectedArea.ID).Load();
            Values = db.RefVals.Where(v => v.Area == SelectedArea.ID).OrderBy(v => v.Description).ToList();
            NotifyPropertyChanged("Values");
            NotifyPropertyChanged("Changed");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand SaveDBChangesCommand { get; private set; }

        public void SaveDBChanges(object parameter)
        {
            db.SaveChanges();
            NotifyPropertyChanged("Changed");
        }
    }
}
