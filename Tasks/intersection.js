'use strict'

// Finde an intersection of two dictionaries

const intersection = (object1, object2) => {
  const res = {};
  const keys = Object.keys(object1);
  for (const key of keys) {
    if (object2[key]) {
      res[key] = object1[key];
    }
  }
return res;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
