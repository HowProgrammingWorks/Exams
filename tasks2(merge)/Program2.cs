Dictionary<Tval1, Tval2> MergeTwoDictionaries<Tval1, Tval2>
    (Dictionary<Tval1, Tval2> dictionary1, Dictionary<Tval1, Tval2> dictionary2)
    {
        Dictionary<Tval1, Tval2> dictionary3 = new Dictionary<Tval1,Tval2>();
        foreach (Tval1 key in dictionary1.Keys)
            dictionary3[key] = dictionary1[key];
        foreach (Tval2 key in dictionary2.Keys)
            dictionary3[key] = dictionary2[key];
        return dictionary3;
    }

Dictionary<char, string> result = MergeTwoDictionaries<char, string>
(new Dictionary<char,string>() { { 'a', "uno" }, { 'b', "due" } }, 
new Dictionary<char, string> { { 'c', "tre" } });
foreach (char resultKey in result.Keys)
    Console.Write($"{resultKey}:{result[resultKey]} ");
Console.ReadKey();
