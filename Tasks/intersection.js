'use strict';

const intersection = (obj1, obj2) => {
  const res = {};
  const firstKeys = Object.keys(obj1);
  for (const item of firstKeys) {
    if (obj1[item] === obj2[item]) {
      res[item] = obj1[item];
    }
  }
  return res;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
