// Finde an intersection of two dictionaries
'use strict';

const intersection = (obj1, obj2) => {
  const res = {};
  const keys1 = Object.keys(obj1);
  for (const key of keys1) {
    if (obj2[key]) {
      res[key] = obj1[key];   
    }
  }
  return res;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
