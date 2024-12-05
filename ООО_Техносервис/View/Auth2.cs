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



namespace ООО_Техносервис.View
{
    public partial class Auth2 : Form
    {
        public Auth2()
        {
            InitializeComponent();
        }



        private void buttonAuth_Click(object sender, EventArgs e)
        {
            //Вход в систему по логину и паролю
            string login, password;
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;
            //Результат запроса на получение всех пользователей
            //List <Model.User> users = Helper.DBRequest.User.ToList();
            //Model.User user  = null;


            //// Первый вариант поиска по базе (перебор всех пользователей)
            //foreach (Model.User u in users)
            //{
            //    if (u.User_Login == login && u.User_Password == password)
            //    {
            //        user = u;
            //        break;
            //    }
            //}


            //// Второй вариант поиска по базе
            //List<Model.User> usersWhere = users.Where(u => u.User_Login == login && u.User_Password == password).ToList();
            //user = usersWhere.FirstOrDefault();


            // Третий вариант поиска по базе
            Helper.user = Helper.DBRequest.User.Where(u => u.User_Login == login && u.User_Password == password).FirstOrDefault();
            

            //Сообщение о нахождении записи в БД
            if (Helper.user != null)
            {
                MessageBox.Show("Найдено. Вы вошли срулью " + Helper.user.Role.Role_Name);
                // Создание окна
                RequestList requestList = new RequestList();  
                // Скрываем текущее окно
                this.Hide();
                requestList.ShowDialog(); // Открыть окно списка
                this.Show(); // Показать окно авторизации после закрытия окна списка

            }
            else
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void Auth2_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    Helper.DBRequest = new Model.DBDomayskaya21Entities();
                    MessageBox.Show("К БД подключились");
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к БД"); Environment.Exit(-1); 
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}
