﻿using Kakoito_minys_vaib;
using MyApp;
using System.Collections;

//какой то минус вайб
namespace MyApp.Kakoito_minys_
{
    internal class Admin : crudi, IEnumerable<Polzovatel>
    {
        int _i, _pos;
        List<Polzovatel>? _Polzovateli = new();
        private crudi _crudiImplementation;
        public string? login;
        public string password;
        public Rolllli Role { get; set; }
//че то я сегодня не в потоке, да и не в ресурсе
        public void AdminPanal(string? login)
        {
            while (true)
            {
                _i = 3;
                _Polzovateli = json.Load();
                Console.Clear();
                Console.SetCursorPosition(10, 0);
                Console.Write("Добро пожаловать, " + login);
                Console.SetCursorPosition(80, 0);
                Console.WriteLine("Роль: Администратор");
                for (int i = 0; i < 120; i++)
                    Console.Write("-");
                for (int i = 2; i < 10; i++)
                {
                    Console.SetCursorPosition(90, i);
                    Console.Write("|");
                }
                Console.SetCursorPosition(95, 2);
                Console.Write("F1 - добавить запись");
                Console.SetCursorPosition(10, 2);
                Console.Write("ID");
                Console.SetCursorPosition(30, 2);
                Console.Write("Логин");
                Console.SetCursorPosition(50, 2);
                Console.Write("Пароль");
                Console.SetCursorPosition(70, 2);
                Console.Write("Роль");
                if (_Polzovateli != null)
                {
                    foreach (Polzovatel unused in _Polzovateli)
                    {
                        Console.SetCursorPosition(10, _i);
                        Console.Write(Polzovatel.Id);
                        Console.SetCursorPosition(30, _i);
                        Console.Write(Polzovatel.login);
                        Console.SetCursorPosition(50, _i);
                        Console.Write(Polzovatel.password);
                        Console.SetCursorPosition(70, _i);
                        Console.Write(Polzovatel.Role);
                        _i++;
                    }

                    _pos = Key.CheckPos(3, _i - 1);
                    if (_pos == -1)
                        Create(_Polzovateli);
                    if (_pos >= 2)
                        Read(_Polzovateli, _Polzovateli[_pos - 3], _pos - 3);
                }
            }
        }

        public void Create(List<Polzovatel>? users)
        {
            int id = 0, role = 0;
            string? login = "";
            string? password = "";
            Rolllli Role = new Rolllli();
            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.Write("Добро пожаловать, admin");
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: Администратор");
            for (int i = 0; i < 120; i++)
                Console.Write("-");
            for (int i = 2; i < 10; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(95, 2);
            Console.Write("0 - Администратор");
            Console.SetCursorPosition(95, 3);
            Console.Write("1 - Кассир");
            Console.SetCursorPosition(95, 4);
            Console.Write("2 - Кадровик");
            Console.SetCursorPosition(95, 5);
            Console.Write("3 - Склад-менеджер");
            Console.SetCursorPosition(95, 6);
            Console.Write("4 - Бухгалтер");
            Console.SetCursorPosition(95, 8);
            Console.Write("S - Сохранить изменения");
            Console.SetCursorPosition(95, 9);
            Console.Write("Escape - Вернуться в меню");
            Console.SetCursorPosition(3, 2);
            Console.Write("ID:");
            Console.SetCursorPosition(3, 3);
            Console.Write("Логин:");
            Console.SetCursorPosition(3, 4);
            Console.Write("Пароль:");
            Console.SetCursorPosition(3, 5);
            Console.Write("Роль:");
            do
            {
                _pos = Key.CheckPos(2, 5);
                if (_pos == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(7, 2);
                    id = Convert.ToInt32(Console.ReadLine());
                }
                if (_pos == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(10, 3);
                    login = Console.ReadLine();
                }
                if (_pos == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(11, 4);
                    password = Console.ReadLine();
                }
                if (_pos == 5)
                {
                    Console.SetCursorPosition(9, 5);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(9, 5);
                    role = Convert.ToInt32(Console.ReadLine());
                    switch (role)
                    {
                        case 0:
                            Role = Rolllli.Admin;
                            break;
                        case 1:
                            Role = Rolllli.Kassir;
                            break;
                        case 2:
                            Role = Rolllli.Kadrovik;
                            break;
                        case 3:
                            Role = Rolllli.ScladManager;
                            break;
                        case 4:
                            Role = Rolllli.Bugalter;
                            break;
                    }
                }
            } while (_pos >= 2);
            if (_pos == -5)
            {
                Polzovatel user = new Polzovatel(id, login, password, Role);
                users?.Add(user);
                json.Save(users);
            }

        }
//эх...щас бы на море
        public void Create(List<Polzovatel>? users, jsonchiki missing_name)
        {
            throw new NotImplementedException();
        }

        public void Read(List<Polzovatel>? users, Polzovatel user, int posit)
        {

            int role;
            Console.Clear();
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.Write("Добро пожаловать, admin");
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: Администратор");
            for (int i = 0; i < 120; i++)
                Console.Write("-");
            for (int i = 2; i < 10; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(95, 2);
            Console.SetCursorPosition(95, 2);
            Console.Write("0 - Администратор");
            Console.SetCursorPosition(95, 3);
            Console.Write("1 - Кассир");
            Console.SetCursorPosition(95, 4);
            Console.Write("2 - Кадровик");
            Console.SetCursorPosition(95, 5);
            Console.Write("3 - Склад-менеджер");
            Console.SetCursorPosition(95, 6);
            Console.Write("4 - Бухгалтер");
            Console.SetCursorPosition(95, 8);
            Console.Write("S - Сохранить изменения");
            Console.SetCursorPosition(95, 9);
            Console.Write("Delete - Удалить элемент");
            Console.SetCursorPosition(95, 10);
            Console.Write("Escape - Вернуться в меню");

            Console.SetCursorPosition(3, 2);
            Console.Write("ID: " + Polzovatel.Id);
            Console.SetCursorPosition(3, 3);
            Console.Write("Логин: " + Polzovatel.login);
            Console.SetCursorPosition(3, 4);
            Console.Write("Пароль: " + Polzovatel.password);
            Console.SetCursorPosition(3, 5);
            Console.Write("Роль: " + Polzovatel.Role);
            do
            {
                _pos = Key.CheckPos(2, 5);
                if (_pos == 2)
                {
                    Console.SetCursorPosition(7, 2);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(7, 2);
                    Polzovatel.Id = Convert.ToInt32(Console.ReadLine());
                }
                if (_pos == 3)
                {
                    Console.SetCursorPosition(10, 3);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(10, 3);
                    Polzovatel.login = Console.ReadLine();
                }
                if (_pos == 4)
                {
                    Console.SetCursorPosition(11, 4);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(11, 4);
                    Polzovatel.password = Console.ReadLine();
                }
                if (_pos == 5)
                {
                    Console.SetCursorPosition(9, 5);
                    Console.Write("                                                                                ");
                    Console.SetCursorPosition(9, 5);
                    role = Convert.ToInt32(Console.ReadLine());
                    switch (role)
                    {
                        case 0:
                            Polzovatel.Role = Rolllli.Admin;
                            break;
                        case 1:
                            Polzovatel.Role = Rolllli.Kassir;
                            break;
                        case 2:
                            Polzovatel.Role = Rolllli.Kadrovik;
                            break;
                        case 3:
                            Polzovatel.Role = Rolllli.ScladManager;
                            break;
                        case 4:
                            Polzovatel.Role = Rolllli.Bugalter;
                            break;
                    }
                }
            } while (_pos >= 2);
            if (_pos == -5)
            {
                if (users != null)
                {
                    users[posit] = user;
                    json.Save(users);
                }
            }
            if (_pos == -15)
            {
                Delete(_Polzovateli, posit);
            }
        }

        public void Update()
        {
            _crudiImplementation.Update();
        }

        public void Update(List<Polzovatel>? users, int posit)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.Write("Обновление пользователя");
            Console.SetCursorPosition(10, 2);
            Console.Write("Логин: ");
            string newLogin = Console.ReadLine();
            Console.SetCursorPosition(10, 4);
            Console.Write("Пароль: ");
            string newPassword = Console.ReadLine();
            Console.SetCursorPosition(10, 6);
            Console.Write("Роль (0 - Админ, 1 - Кассиршаа, 2 - Кадровичек, 3 - Менеджер склада, 4 - Бухгалтер): ");
            int newRole = Convert.ToInt32(Console.ReadLine());
            Rolllli role = Rolllli.Admin;
            switch (newRole)
            {
                case 1:
                    role = Rolllli.Kassir;
                    break;
                case 2:
                    role = Rolllli.Kadrovik;
                    break;
                case 3:
                    role = Rolllli.ScladManager;
                    break;
                case 4:
                    role = Rolllli.Bugalter;
                    break;
            }

            if (users != null && posit >= 0 && posit < users.Count)
            {
                Polzovatel updatedUser = new Polzovatel(Polzovatel.Id, newLogin, newPassword, role);
                users[posit] = updatedUser;
                json.Save(users);
                Console.Clear();
                Console.WriteLine("Информация о пользователе успешно обновлена.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ошибка: Не удалось обновить информацию о пользователе.");
            }
        }

        public void Delete(List<Polzovatel>? users, int posit)
        {
            if (users != null && posit >= 0 && posit < users.Count)
            {
                users.RemoveAt(posit);
                json.Save(users);
                Console.Clear();
                Console.WriteLine("Пользователь успешно удален.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ошибка: Не удалось удалить пользователя.");
            }
        }

        IEnumerator<Polzovatel> IEnumerable<Polzovatel>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Add(Polzovatel admin)
        {
        }
//хочу лето...и пиццу и автомат по 'с#'
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
