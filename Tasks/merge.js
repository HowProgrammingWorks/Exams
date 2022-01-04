'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
    const result = {};
   for (const key in obj1) {
        result[key] = obj1[key]
  }
   for (attribute_name in obj2) {
      (result[attribute_name] == obj2[attribute_name])
     result[attribute_name] = obj2[attribute_name]
    }
return obj1, obj2, result;
}

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
