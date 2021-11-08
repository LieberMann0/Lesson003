// По заданному номеру дня недели вывести его название


string[] DName = new string[8] {"Необходимо вводить число от 1 до 7", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};

Console.Write("Введите номер дня недели: - ");
int index = Convert.ToInt32(Console.ReadLine());

if (index > 7) Console.WriteLine("Необходимо вводить число от 1 до 7");
if (index < 0) Console.WriteLine("Необходимо вводить число от 1 до 7");

Console.WriteLine(DName[index]);
