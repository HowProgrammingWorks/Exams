    Funct <Dictionary<object, object>, Dictionary<object, object>, Dictionary<object, object>> d =
        (Dictionary<object, object> object_1, Dictionary<object, object> object_2) =>
    {
        foreach (object attribute_name in object_2.Keys)
            object_1.Remove(attribute_name);
        return object_1;
    };

    Dictionary<object, object> result = d
        (new Dictionary<object, object> { { 'a', "uno" }, { 'b', "due"} }, 
        new Dictionary<object,object>{ { 'a', "uno" }, { 'c', "tre" } });
    foreach (object k in result.Keys)
        Console.Write($"{k}:{result[k]} ");
    Console.ReadKey();
