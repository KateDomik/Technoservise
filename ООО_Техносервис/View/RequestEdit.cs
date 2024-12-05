using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООО_Техносервис.Model;
using ООО_Техносервис.Classes;



// Заказчик 
// loginDEppn2018
// 6}i+FD

// Мастер
// loginDEdpy2018
// MJ0W|f

// Оператор
// loginDExvq2018
// hX0wJz

namespace ООО_Техносервис.View
{
    public partial class RequestEdit : Form
    {
        Model.Request Request = null;
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="id">Номер выбранной заявки</param>
        public RequestEdit(int id)
        {
            InitializeComponent();
            if (id > 0 )
            {
                Request = Helper.DBRequest.Request.Where(r => r.Request_ID == id).FirstOrDefault();
            }
        }


        public RequestEdit()
        {
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {

            

            //Настройка комбобоксов
            comboBoxEquipment.DataSource = Helper.DBRequest.Device.ToList();
            comboBoxEquipment.DisplayMember = "Device_Name";
            comboBoxEquipment.ValueMember = "Device_ID";

            comboBoxProblem.DataSource = Helper.DBRequest.Defect.ToList();
            comboBoxProblem.DisplayMember = "Defect_Name";
            comboBoxProblem.ValueMember = "Defect_ID";

            comboBoxClient.DataSource = Helper.DBRequest.User.Where(u => u.User_Role_ID == 1).ToList();
            comboBoxClient.DisplayMember = "User_Full_Name";
            comboBoxClient.ValueMember = "User_ID";

            comboBoxStatus.DataSource = Helper.DBRequest.Status.ToList();
            comboBoxStatus.DisplayMember = "Status_Name";
            comboBoxStatus.ValueMember = "Status_ID";

            comboBoxMaster.DataSource = Helper.DBRequest.User.Where(u => u.User_Role_ID == 2).ToList();
            comboBoxMaster.DisplayMember = "User_Full_Name";
            comboBoxMaster.ValueMember = "User_ID";

            comboBoxPriority.DataSource = Helper.DBRequest.Priory.ToList();
            comboBoxPriority.DisplayMember = "Priory_Name";
            comboBoxPriority.ValueMember = "Priory_ID";

            comboBoxStage.DataSource = Helper.DBRequest.Stage.ToList();
            comboBoxStage.DisplayMember = "Stage_Name";
            comboBoxStage.ValueMember = "Stage_ID";

            textBoxDate.Text = DateTime.Now.ToShortDateString();


            if (Request == null)
            {
                textBoxDate.Text = DateTime.Now.ToShortDateString();
                comboBoxStatus.SelectedValue = 1;
                comboBoxStage.SelectedValue = 3;
                textBoxTime.Text = "0";
            }
            else
            {
                //Заполняем все элементы интерфейса значениями выбранной заявки
                //Для ComboBox - это свойство SelectValue,
                //для него настроено свойство ValueMember нужным полем 
                comboBoxEquipment.SelectedValue = Request.Request_Device_ID;
                comboBoxProblem.SelectedValue = Request.Request_Defect_ID;
                comboBoxClient.SelectedValue = Request.Request_Client_ID;
                comboBoxMaster.SelectedValue = Request.Request_Master_ID;
                comboBoxPriority.SelectedValue = Request.Request_Priory_ID;
                comboBoxStatus.SelectedValue = Request.Request_Status_ID;
                comboBoxStage.SelectedValue = Request.Request_Status_ID;
                //Значение берем из полей выбранной заявки
                textBoxDate.Text = Request.Request_Date.ToShortDateString();
                textBoxTime.Text = Request.Request_Time.ToString();
            }

            if (Helper.user.User_Role_ID == 3)
            {
                //Оператор в режиме Добавление и Редактирование может менять поле Мастера
                comboBoxMaster.Enabled = true;
                //Включаем элементы доступные оператору в режиме Добавления 
                if (Request == null)
                {
                    comboBoxEquipment.Enabled = comboBoxClient.Enabled = comboBoxMaster.Enabled =
                 comboBoxPriority.Enabled = comboBoxPriority.Enabled = comboBoxProblem.Enabled = textBoxComment.Enabled = true;
                }
                
            }
            if (Helper.user.User_Role_ID == 2)    //Оператор только в режиме Редактирования
            {
                //Может менять только время обслуживания заявки, ее этап и комментарий
                textBoxTime.Enabled = comboBoxStage.Enabled = textBoxComment.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Request == null)
            { 
                Request = new Request();
                Request.Request_Date = DateTime.Parse(this.textBoxDate.Text);
                Request.Request_Device_ID = (int)comboBoxEquipment.SelectedValue;
                Request.Request_Defect_ID = (int)comboBoxProblem.SelectedValue;
                Request.Request_Client_ID = (int)comboBoxClient.SelectedValue;
                Request.Request_Description = textBoxDescription.Text;
                Request.Request_Status_ID = (int)comboBoxStatus.SelectedValue;
                Request.Request_Master_ID = (int)comboBoxMaster.SelectedValue;
                Request.Request_Time = int.Parse(textBoxTime.Text);
                Request.Request_Priory_ID = (int)comboBoxPriority.SelectedValue;
                Request.Request_Stage_ID = (int)comboBoxStage.SelectedValue;
                Request.Request_Comment = textBoxComment.Text;

                Helper.DBRequest.Request.Add(Request);

                try
                {
                    Helper.DBRequest.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены");
                }
                catch  (Exception) {
                    MessageBox.Show("Данные не добавлены");
                    return;
                }
                this.Close();

            }

        }
    }
}
