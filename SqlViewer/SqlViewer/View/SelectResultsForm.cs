using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer.View
{
    public partial class SelectResultsForm : Form
    {
        public SelectResultsForm(DataTable table)
        {
            InitializeComponent();
            Init(table);
        }

        private void Init(DataTable table)
        {
            Text = table.TableName;
            dgResults.DataSource = table;
        }
    }
}
