Dictionary<object, object> merge_two_objects(Dictionary<object, object> object_1, Dictionary<object, object> object_2)
            {
                Dictionary<object, object> object_3 = new Dictionary<object,object>();

                foreach (object attribute_name in object_1.Keys)
     {

                    object_3[attribute_name] = object_1[attribute_name];
                }
                foreach (object attribute_name in object_2.Keys)
                {

                    object_3[attribute_name] = object_2[attribute_name];
            }
                return object_3;
            }

            var result = merge_two_objects(new Dictionary<object,object>() { { 'a', "uno" }, { 'b', "due" } }, new Dictionary<object, object> { { 'c', "tre" } });
            foreach (char a in result.Keys)
                Console.Write($"{a}:{result[a]} ");
            Console.ReadKey();
