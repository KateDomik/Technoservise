using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООО_Техносервис.Classes
{
    //Класс с глобальными величинами
    public class Helper
    {
        // BD connection
        public static Model.DBDomayskaya21Entities DBRequest { get; set; } // static означает, что объект будет в единственном экземпляре

        //
        public static Model.User user;
    }
}
