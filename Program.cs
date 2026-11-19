// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());

// Hero margarita = new Hero("Маргарита", 80);
// margarita.TakeDamage(30);
// margarita.Heal(15);
// margarita.GainExperience(50);
// Console.WriteLine(margarita.IsAlive());
// Console.WriteLine(margarita.GetInfo());

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 100);

// yaroslav.TakeDamage(40);
// anastasia.TakeDamage(10);

// Console.WriteLine($"Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Анастасия: {anastasia.Health}");

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("Александр", 150);

// Console.WriteLine(yaroslav.GetInfo());
// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());
// Console.WriteLine();
// Console.WriteLine(alexander.GetInfo());

// alexander.Health = 5000;
// Console.WriteLine($"После прямой записи: {alexander.Health}");

// alexander.Health = -100;
// Console.WriteLine($"После второй записи: {alexander.Health}");
// Hero healthProbe = new Hero("Проверка конструктора", -100);
// Console.WriteLine($"После создания: {healthProbe.Health}");
// alexander.Heal(5000);
// Console.WriteLine($"После большого лечения: {alexander.Health}");
// Hero lowProbe = new Hero("Проверка нижней границы", -100);
// Hero highProbe = new Hero("Проверка верхней границы", 5000);
// Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
// Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
// Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

// alexander.TakeDamage(30);
// alexander.Heal(10);
// Console.WriteLine($"Обычные действия: {alexander.Health}");
// alexander.Heal(5000);
// Console.WriteLine($"Большое лечение: {alexander.Health}");
// alexander.Heal(-20);
// Console.WriteLine($"Отказ в лечении: {alexander.Health}");
// alexander.TakeDamage(5000);
// Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
// alexander.Heal(20);
// Console.WriteLine($"Восстановление: {alexander.Health}");
// Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");

// Hero spacedProbe = new Hero("   Александр   ", 150);
// Hero emptyProbe = new Hero("   ", 100);

// Console.WriteLine($"Имя с пробелами: [{spacedProbe.Name}]");
// Console.WriteLine($"Пустая запись: [{emptyProbe.Name}]");
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(-10);
// yaroslav.GainExperience(2147483647);
// Console.WriteLine($"После проверок опыта: {yaroslav.Experience}");

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");