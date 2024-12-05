using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class RequestList : Form
    {
        public RequestList()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        /// <summary>
        /// отобразить список заявок при загрузке окна
        /// </summary>
        public void Show_Requests()
        {
            // Получить записи из БД
            List<Model.Request> list = Classes.Helper.DBRequest.Request.ToList();



            // Фильтрация заявок по срули
            switch(Helper.user.User_Role_ID)
            {
                case 1:  //Заказчик
                    list = list.Where(r => r.Request_Client_ID == Helper.user.User_ID).ToList();
                    break;
                case 2:  //Мастер
                    list = list.Where(r => r.Request_Master_ID == Helper.user.User_ID).ToList();
                    buttonEditRequest.Visible = true;
                    break;
                case 3:  //Оператор
                    buttonEditRequest.Visible = true;
                    buttonAddRequest.Visible = true;

                    break;
                case 4:  //Менеджер
                    buttonReport.Visible = true;
                    break;
            }


            this.dataGridViewRequest.Rows.Clear();
            int numberStatus = (int)statusFilter.SelectedIndex;
            if (numberStatus > 0)
            {
                list = list.Where(r => r.Request_Status_ID == numberStatus).ToList();
            
            }
            // Поиск по номеру
            if (numberSearch.Text != "")
            {
                list = list.Where(r => r.Request_ID.ToString().Contains(numberSearch.Text)).ToList();
            }
            this.dataGridViewRequest.Rows.Clear(); // Очистили все строки
                                                   // Цикл по перебору всех заявок

        int i = 0;

            // Цикл по перебору всех заявок
            foreach (Model.Request request in list)
            {
                this.dataGridViewRequest.Rows.Add();
                dataGridViewRequest.Rows[i].Cells[0].Value = request.Request_ID;
                dataGridViewRequest.Rows[i].Cells[1].Value = request.Request_Date.ToLongDateString();
                dataGridViewRequest.Rows[i].Cells[2].Value = request.Device.Device_Name;
                dataGridViewRequest.Rows[i].Cells[3].Value = request.User.User_Full_Name;
                dataGridViewRequest.Rows[i].Cells[4].Value = request.Status.Status_Name;
                dataGridViewRequest.Rows[i].Cells[5].Value = request.User1.User_Full_Name;
                dataGridViewRequest.Rows[i].Cells[6].Value = request.Stage.Stage_Name;
                i++;
            }



        }

        /// <summary>
        ///  При загрузке окна отобразить список заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RequestList_Load(object sender, EventArgs e)
        {

            //Заполнить комбобокс статусами из БД
            List<Model.Status> statuses = Classes.Helper.DBRequest.Status.ToList();
            //Новый статус
            Model.Status status = new Model.Status();
            status.Status_ID = 0;
            status.Status_Name = "Все статусы";
            //Добавить новый статус к остальным
            statuses.Insert(0, status);

            statusFilter.DataSource = statuses;

            //Какое поле будет видеть пользователь
            statusFilter.DisplayMember = "Status_Name";
            statusFilter.ValueMember = "Status_ID";
            statusFilter.SelectedIndex = 0;

            Show_Requests();
        }

        /// <summary>
        /// Выбор статуса для фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Show_Requests();
        }

        /// <summary>
        /// Ввод номера заявки для фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberSearch_TextChanged(object sender, EventArgs e)
        {

            Show_Requests();
        }

        /// <summary>
        /// Добавить заявку для роли оператор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRequest_Click_1(object sender, EventArgs e)
        {
            //RequestWork workRequest = new RequestWork(0);
            RequestEdit editRequest = new RequestEdit();
            this.Hide();
            editRequest.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Изменение заявки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            // Проверили, что есть выбранная заявка
            if (dataGridViewRequest.SelectedRows.Count > 0)
            {
                // Получили номер выбранной заявки
                int id = (int)dataGridViewRequest.CurrentRow.Cells[0].Value;
                // Открыли окно и передали в него номер выбранной заявки
                RequestEdit editRequest = new RequestEdit(id);
                this.Hide();
                editRequest.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана заявка для редактирования");
            }

        }

        private void RequestList_Shown(object sender, EventArgs e)
        {
            Show_Requests();
        }

        private void RequestList_Activated(object sender, EventArgs e)
        {
            Show_Requests();
        }





        // Отобразить список заявок в сетке просто так
        //dataGridViewRequest.DataSource = list;
    }

}

