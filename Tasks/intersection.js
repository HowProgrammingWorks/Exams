// Finde an intersection of two dictionaries
'use strict';

const intersection = (obj1, obj2) => {
  const result = {};
  const keys = Object.keys(obj1);
  for (const key of keys) {
    if (obj2[key]) {
      result[key] = obj1[key];
    }
  }
  return result;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
