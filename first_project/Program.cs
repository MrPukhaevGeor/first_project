```csharp
using System;

public class MainClass
{
    static string word;
    static string current;
    static int score;

    public static void Main()
    {
        StartGame();
        
        while (current != word)
        {
            ShowScore();
            PlayTurn();
        }
        
        EndGame();
    }

    static void StartGame()
    {
        string words = "метро автобус такси трамвай поезд самолет велосипед";
        string[] arr = words.Split(' ');
        word = arr[new Random().Next(0, arr.Length)];
        
        current = "";
        for (int i = 0; i < word.Length; i++)
        {
            current += "_";
        }
        
        Console.WriteLine("Для угадывания слова напишите: 'слово'");
        Console.WriteLine();
    }

    static void ShowScore()
    {
        Console.WriteLine("Очки: " + score);
        Console.WriteLine();
    }

    static void PlayTurn()
    {
        string[] sectors = {"П", "+", "350", "450", "550", "600", "650", "Б", "х2", "700", "300", "400", "500"};
        string sector = sectors[new Random().Next(0, sectors.Length)];
        
        if (sector == "Б")
        {
            Console.WriteLine("Банкрот! Все пропало!");
            score = 0;
            return;
        }
        
        if (sector == "+")
        {
            Console.WriteLine(current);
            Console.WriteLine("Открыть букву под номером:");
            int num = int.Parse(Console.ReadLine());
            
            string temp = "";
            for (int i = 0; i < current.Length; i++)
            {
                if (i == num - 1)
                {
                    temp += word[num - 1];
                }
                else
                {
                    temp += current[i];
                }
            }
            current = temp;
            Console.WriteLine(current);
            return;
        }
        
        if (sector == "х2")
        {
            Console.WriteLine("Удвоение! Следующая буква х2");
            return;
        }
        
        if (sector == "П")
        {
            string[] gifts = {"10 по колоку", "0 по колоку", "габелла на сессии", "похвала и почет", "+респект", "14к в дотке", "шиза", "приора для орг"};
            string gift = gifts[new Random().Next(0, gifts.Length)];
            Console.WriteLine("Ваш приз: " + gift);
            current = word;
            return;
        }
        
        int points = int.Parse(sector);
        Console.WriteLine("Выпало: " + points + " очков");
        Console.WriteLine("Буква:");
        
        string cmd = Console.ReadLine();
        
        if (cmd == "слово")
        {
            Console.WriteLine("Ваш вариант:");
            string guess = Console.ReadLine();
            if (guess == word)
            {
                Console.WriteLine("Правильно! Победа!");
                current = word;
            }
            else
            {
                Console.WriteLine("Не угадали!");
            }
            return;
        }
        
        char letter = cmd[0];
        string newCurrent = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == letter)
            {
                newCurrent += letter;
            }
            else
            {
                newCurrent += current[i];
            }
        }
        
        if (newCurrent != current)
        {
            score += points;
            Console.WriteLine("Есть буква!");
        }
        
        current = newCurrent;
        Console.WriteLine(current);
    }

    static void EndGame()
    {
        Console.WriteLine("Игра окончена! Слово: " + word);
        Console.WriteLine("Очки: " + score);
        
        string[] prizes = {"Кружка", "Футболка", "Блокнот", "Ручка", "Брелок"};
        int[] costs = {100, 500, 200, 50, 300};
        
        Console.WriteLine("Выбор приза:");
        for (int i = 0; i < prizes.Length; i++)
        {
            Console.WriteLine((i+1) + ") " + prizes[i] + " - " + costs[i]);
        }
        
        int choice = int.Parse(Console.ReadLine());
        if (costs[choice - 1] <= score)
        {
            Console.WriteLine("Ваш приз: " + prizes[choice - 1]);
        }
    }
}
```
