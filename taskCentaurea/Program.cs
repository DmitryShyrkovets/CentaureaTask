string[] exampleWords = 
{
    "Эй",
    "Привет",
    "это",
    "тестовый",
    "набор",
    "слов",
    "Абрикос",
};

string vowels = "аиеёоуыэюя";

string StringBuilder(string[] words) {
    
    int[] vowelsCount = new int[words.Length];

    int index = 0;

    foreach (var word in words)
    {
        foreach (var letter in word.ToLower())
        {
            if (vowels.IndexOf(letter) != -1)
                vowelsCount[index]++;
        }
        
        index++;
    }

    Array.Sort(vowelsCount, words);
    
    string result = String.Join(" ", words);

    return result;
}

Console.WriteLine(StringBuilder(exampleWords));
