    Funct <Dictionary<object, object>, Dictionary<object, object>, Dictionary<object, object>> Difference =
        (Dictionary<object, object> dict1, Dictionary<object, object> dict2) =>
    {
        foreach (object dictKey in dict2.Keys)
            dict1.Remove(dictKey);
        return dict1;
    };

    Dictionary<object, object> result = Difference
        (new Dictionary<object, object> { { 'a', "uno" }, { 'b', "due"} }, 
        new Dictionary<object,object>{ { 'a', "uno" }, { 'c', "tre" } });
    foreach (object key in result.Keys)
        Console.Write($"{key}:{result[key]} ");
    Console.ReadKey();
