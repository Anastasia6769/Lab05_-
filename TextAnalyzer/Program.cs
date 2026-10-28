Console.WriteLine();
Console.WriteLine("Меню");

string menuChoice;
do {
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
    menuChoice = Console.ReadLine();

    switch (menuChoice){
        case "1":
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;
            int spaces = 0;
            string vowelsList = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
                string consonantsList = "бвгджзйклмнпрстфхцчшщьъБВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ";
            foreach (char letter in sentence){
                if (letter == ' '){
                    spaces++;
                    continue;
                }
                if (vowelsList.Contains(letter))
                    {
                        vowels++;
                    } 
                else if (consonantsList.Contains(letter)){
                        consonants++;
                    }
            }
            Console.WriteLine($"Всего символов: {sentence.Length}");
            Console.WriteLine($"Гласных: {vowels}");
            Console.WriteLine($"Согласных: {consonants}");
            Console.WriteLine($"Пробелов: {spaces}");
            break;

        case "2":
            Console.Write("Введите предложение: ");
            string sentence1 = Console.ReadLine();
            bool found = false;
            string upper = "АЕЁИОУЫЭЮЯБВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ";
            for (int i = 0; i < sentence1.Length; i++){
                char c = sentence1[i];
                if (upper.Contains(c)){
                    Console.WriteLine($"Первая заглавная буква '{c}' находится на позиции: {i}");
                    found = true;
                    break;
                }
            }
            if (!found){
                    Console.WriteLine("Заглавных букв нет");
                }
            break;
        case "0":
            Console.WriteLine("До свидания!");
            break;
        default:
            Console.WriteLine("Такого пункта нет");
            break;
    }
}while (menuChoice != "0");