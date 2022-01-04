    Dictionary<Tvalue1, Tvalue2> Difference<Tvalue1, Tvalue2>
        (Dictionary<Tvalue1, Tvalue2> firstObject, Dictionary<Tvalue1, Tvalue2> secondObject)
    {
        foreach (Tvalue1 attributeName in secondObject.Keys)
        {
            firstObject[attributeName] = secondObject[attributeName];
            firstObject.Remove(attributeName);
        }
        return firstObject;
    }

    Dictionary<char, string> result = Difference<char, string>
        (new Dictionary<char, string> { { 'a', "uno" }, { 'b', "due" } }, 
        new Dictionary<char, string>{ { 'a', "uno" }, { 'c', "tre" } });
    foreach (char key in result.Keys)
        Console.Write($"{key}:{result[key]} ");
    Console.ReadKey();
