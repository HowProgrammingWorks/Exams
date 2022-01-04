Dictionary<object, object> MergeTwoDictionaries
    (Dictionary<object, object> dictionary1, Dictionary<object, object> dictionary2)
    {
        Dictionary<object, object> dictionary3 = new Dictionary<object,object>();
        foreach (object key in dictionary1.Keys)
            dictionary3[key] = dictionary1[key];
        foreach (object key in dictionary2.Keys)
            dictionary3[key] = dictionary2[key];
        return dictionary3;
    }

Dictionary<object, object> result = MergeTwoDictionaries
(new Dictionary<object,object>() { { 'a', "uno" }, { 'b', "due" } }, 
new Dictionary<object, object> { { 'c', "tre" } });
foreach (object resultKey in result.Keys)
    Console.Write($"{resultKey}:{result[resultKey]} ");
Console.ReadKey();
