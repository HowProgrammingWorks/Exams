// Finde a difference of two dictionaries

'use strict';
const difference = (obj1, obj2) => {
  const res={};
  for (const key in obj2) {
    res[key] = obj2[key];
    delete res[key];
  }
  return res;
};
const result = difference({a: 'uno', b: 'due'}, {a: 'uno', c: 'tre'});
console.log(result);
