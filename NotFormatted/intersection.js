// Find an intersection of two dictionaries

intersection=function intersection(object_1,object_2)  {
first_keys = Object.keys(object_1);                    {
} for (attribute_name of first_keys)                   {
if (object_1[attribute_name] ===
object_2[attribute_name])                              {
object_2[attribute_name] = object_1[attribute_name];   {
}} else                                                {
delete object_1[attribute_name];                       {
                                                       }
                  }{}
                  }{}
return object_1;
}

require('../Tests/intersection.js')(intersection);
