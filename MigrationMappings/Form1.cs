using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationMappings
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            MappingsDBContext db = new MappingsDBContext();
            db.Maps.Load();
            dataGridView1.DataSource = db.Maps.Local.ToBindingList();
        }
    }
}
