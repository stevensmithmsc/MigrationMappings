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
        private MappingsDBContext db;

        public Form1()
        {

            InitializeComponent();

            db = new MappingsDBContext();
            db.Maps.Load();
            dataGridView1.DataSource = db.Maps.Local.ToBindingList();

            db.RefAreas.Load();
            comboBox1.DataSource = db.RefAreas.Local.ToBindingList();
            comboBox1.DisplayMember = "Area";
            comboBox1.ValueMember = "ID";

            label1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "ID"));
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "LUP_Table"));
            textBox2.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Prefix"));

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            DataGridViewColumn sysCol = new DataGridViewColumn();
            sysCol.DataPropertyName = "System";
            sysCol.Name = "System";
            sysCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(sysCol);
            DataGridViewColumn numCol = new DataGridViewColumn();
            numCol.DataPropertyName = "Number";
            numCol.Name = "Number";
            numCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(numCol);
            DataGridViewColumn codeCol = new DataGridViewColumn();
            codeCol.DataPropertyName = "Code";
            codeCol.Name = "Code";
            codeCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(codeCol);
            DataGridViewColumn ldescCol = new DataGridViewColumn();
            ldescCol.DataPropertyName = "Local_Description";
            ldescCol.Name = "Local Description";
            ldescCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(ldescCol);
            DataGridViewColumn mtCol = new DataGridViewColumn();
            mtCol.DataPropertyName = "MapTo";
            mtCol.Name = "Map To";
            mtCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(mtCol);


            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();
            DataGridViewColumn descCol = new DataGridViewColumn();
            descCol.DataPropertyName = "Description";
            descCol.Name = "Description";
            descCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView2.Columns.Add(descCol);
            DataGridViewColumn ddCol = new DataGridViewColumn();
            ddCol.DataPropertyName = "Data_Dic";
            ddCol.Name = "Data Dictionary";
            ddCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView2.Columns.Add(ddCol);
            DataGridViewColumn parisCol = new DataGridViewColumn();
            parisCol.DataPropertyName = "Paris_Code";
            parisCol.Name = "Paris Code";
            parisCol.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView2.Columns.Add(parisCol);

            toolStripStatusLabel1.Text = db.ChangeTracker.HasChanges().ToString();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefArea theArea = ((RefArea)comboBox1.SelectedItem);

            
            
            dataGridView1.DataSource = theArea.Maps.ToList();
            dataGridView2.DataSource = theArea.RefVals.ToList();

            toolStripStatusLabel1.Text = db.ChangeTracker.HasChanges().ToString();

        }
    }
}
