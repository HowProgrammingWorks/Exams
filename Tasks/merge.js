'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
    const object_3 = {};
   for (attribute_name in obj1) {
       (
          object_3[attribute_name] == obj1[attribute_name]
       );
        object_3[attribute_name] = obj1[attribute_name]
  }
   for (attribute_name in obj2) {
      (object_3[attribute_name] == obj2[attribute_name])
     object_3[attribute_name] = obj2[attribute_name]
    }
return obj1, obj2, object_3;
}

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
