using SqlViewer.Dal;
using SqlViewer.Models;
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
    public partial class NewQueryForm : Form
    {
        public NewQueryForm()
        {
            InitializeComponent();
        }

        private void Tsb_Run_Click(object sender, EventArgs e)
        {
            clearTextBox(tb_message);
            try
            {
                DataSet ds = RepositoryFactory.GetRepository().MakeQuery(tb_query.Text);
                tb_message.Text = "Query completed successfully";
                if (ds.Tables.Count > 0)
                    new SelectResultsForm(ds.Tables[0]).ShowDialog();
            }
            catch (Exception ex)
            {
                tb_message.Text = ex.Message;
            }
        }

        private void Tsb_Clear_Click(object sender, EventArgs e)
        {
            clearTextBox(tb_query);
            clearTextBox(tb_message);
        }

        private void clearTextBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }
    }
}
