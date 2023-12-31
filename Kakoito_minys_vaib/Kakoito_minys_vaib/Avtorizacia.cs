using MyApp;
using MyApp.Kakoito_minys_;


namespace Kakoito_minys_vaib
{

    internal class Authorization
    {
        public void Authorize()
        {
            List<Polzovatel>? users;
            List<Admin> admin = new List<Admin>();
            bool isLoggedIn = false;
            string loggedInUser = "";

            while (!isLoggedIn)
            {
                Console.Clear();
                Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В  МОЙ МАГАЗИН ЦВЕТОВ 'Я УБЬЮСЬ С ЭТИМИ ПРАКТИЧЕСКИМИ', Я СЧИТАЮ ЧТО ТУТ НИКОМУ НЕ ПОНРАВИТСЯ))");
                Console.WriteLine("_______________________________________________________________________________________________");
                Console.WriteLine("  Логин:");
                Console.WriteLine("  Пароль:");
                Console.WriteLine("  Авторизоваться");
                for (int i = 0; i < 20; i++)
                    Console.Write("-");



                users = json.Deserialize<Polzovatel>("path_to_json_file");

                string login = "";
                string password = "";

                while (!isLoggedIn)
                {
                    int pos = Key.CheckPos(2, 4);
//София Алексеевна пожалейте бедную студентку, можно хотя бы '3' за практос, ну или '4'...
                    if (pos == 2)
                    {
                        Console.SetCursorPosition(9, 2);
                        Console.Write(new string(' ', Console.WindowWidth - 9));
                        Console.SetCursorPosition(9, 2);
                        login = Console.ReadLine();
                    }

                    if (pos == 3)
                    {
                        password = "";
                        int passwordPos = 10;
                        Console.SetCursorPosition(10, 3);
                        Console.Write(new string(' ', Console.WindowWidth - 10));
                        Console.SetCursorPosition(10, 3);
                        ConsoleKeyInfo key = Console.ReadKey(true);

                        while (key.Key != ConsoleKey.Enter)
                        {
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                password += key.KeyChar;
                                Console.Write("*");
                                passwordPos++;
                            }
                            else if (key.Key == ConsoleKey.Backspace)
                            {
                                if (!string.IsNullOrEmpty(password))
                                {
                                    password = password.Substring(0, password.Length - 1);
                                    passwordPos--;
                                    Console.SetCursorPosition(passwordPos, 3);
                                    Console.Write(" ");
                                    Console.SetCursorPosition(passwordPos, 3);
                                }
                            }

                            key = Console.ReadKey(true);
                        }
                    }

                    if (pos == 4 && login != "" && password != "")
                    {
                        admin = json.Deserialize<Admin>("User.json");
                        if (admin != null)
                        {
                            foreach (Admin user in admin)
                            {
                                if (user.login == login && user.password == password && user.Role == Rolllli.Admin)
                                {
                                    isLoggedIn = true;
                                    loggedInUser = user.login;
                                     user.AdminPanal(login);
                                    break;
                                }
                            }
                        }
                    }

                    if (pos == 4 && (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)))
                    {
                        Console.WriteLine("Ошибка! Введите логин и пароль.");
                        Console.ReadKey();
                    }

                    if (pos == 4 && !isLoggedIn)
                    {
                        Console.WriteLine("Ошибка! Неверный логин или пароль.");
                        Console.ReadKey();
                    }
                }
            }

            // Выводим имя сотрудника, если пользователь привязан к сотруднику
            if (loggedInUser == "привязка_к_сотруднику")
            {
                Console.WriteLine("Имя сотрудника");
            }
            else
            {
                Console.WriteLine(loggedInUser);
            }

            Console.WriteLine("Нажмите Escape для выхода.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
