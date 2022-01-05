// Finde a difference of two dictionaries

'use strict';
const difference = (obj1, obj2) => {
  const keysOfFirst = Object.keys(obj1);
  const res={};
  for (const key of keysOfFirst) {
    res[key] = obj2[key];
  }
  return res;
};
const result = difference({a: 'uno', b: 'due'}, {a: 'uno', c: 'tre'});
console.log(result);
