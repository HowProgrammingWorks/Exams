'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
    const result = {};
   for (const key in obj1) {
        result[key] = obj1[key]
  }
   for (const key in obj2) {
      (result[key] == obj2[key])
     result[key] = obj2[key]
    }
return obj1, obj2, result;
}

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
