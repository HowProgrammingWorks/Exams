    Dictionary<Tvalue1, Tvalue2> Difference<Tvalue1, Tvalue2>
        (Dictionary<Tvalue1, Tvalue2> dict1, Dictionary<Tvalue1, Tvalue2> dict2)
    {
        foreach (Tvalue1 dictKey in dict2.Keys)
            dict1.Remove(dictKey);
        return dict1;
    }

    Dictionary<char, string> result = Difference<char, string>
        (new Dictionary<char, string> { { 'a', "uno" }, { 'b', "due" } }, 
        new Dictionary<char, string>{ { 'a', "uno" }, { 'c', "tre" } });
    foreach (char key in result.Keys)
        Console.Write($"{key}:{result[key]} ");
    Console.ReadKey();
