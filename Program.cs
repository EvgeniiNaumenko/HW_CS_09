using System.Data;

namespace HW_09_14_06_2024
{
//Завдання 2:
//Створіть додаток «Англо-французький словник», який має
//зберігати наступну інформацію:
// слово англійською мовою;
// варіанти перекладу французькою.
//Для зберігання інформації використовуйте Dictionary<T>.
//Додаток має надавати таку функціональність:
// додати слово і варіанти перекладу;
// видалити слово;
// видалити варіанти перекладу;
// зміна слова;
// зміна варіанта перекладу;
// пошук перекладу слова.

    internal class Program
    {
        static void Main(string[] args)
        {
            EngFrDictionary dict = new EngFrDictionary();
            dict.AddNewWord("Hello", "Bonjour");
            dict.AddNewWord("Book", "Livre");
            dict.AddTranslation("Book", "Réserver");
            Console.WriteLine(dict);
            Console.WriteLine("====================");
            dict.AddNewWord("Match", "Correspondre");
            dict.AddTranslation("Match", "Allumette");
            dict.AddTranslation("Match", "Match");
            Console.WriteLine(dict);
            Console.WriteLine("====================");
            dict.ChangeTranslation("Match", "Correspondre");
            Console.WriteLine(dict);
            Console.WriteLine("====================");
            string word = "Hello";
            Console.WriteLine($"{word} translation: {dict.Translate(word)}");
            dict.DeleteWord(word);
            Console.WriteLine(dict);
            Console.WriteLine("====================");
            EngFrDictionary dict2 = new EngFrDictionary();
            dict2.AddNewWord("Fair", "Juste");
            dict2.AddNewWord("Right", "Droit");
            dict2.AddNewWord("Left", "Gauche");
            dict += dict2;
            Console.WriteLine(dict);
            Console.WriteLine("====================");
        }
    }
}
