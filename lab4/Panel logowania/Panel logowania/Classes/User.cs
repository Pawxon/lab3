using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_logowania.Classes
{
    class User
    {
        //te get i set to tak zwane magiczne metody
        //dzięki nim można się odwoływać do tych zmiennych za pomocą kropki i nie trzeba robić getterów i setterów
        //więc jak masz var User = new User();
        //to możesz zrobić tak:
        //var Login = User.Login
        //a nie tak:
        //var Login = User.GetLogin();
        //tak jakby wszyskie zmienne były publiczne
        public string Login { get; set; }
        public string HashedPasword { get; set; }

        //niepotrzebny gettter
        //public string GetLogin(){ return Login }
    }
}
