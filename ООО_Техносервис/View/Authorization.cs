using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО_Техносервис.View
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            try
            {
                Classes.Helper.DBRequest = new Model.DBDomayskaya21Entities();
                MessageBox.Show("БД подключена");
            }
            catch (Exception)
            {
                MessageBox.Show("Нет соединения с БД");
                Environment.Exit(-1);
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
