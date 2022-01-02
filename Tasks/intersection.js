'use strict';

const intersection = (obj1, obj2) => {
  const res = {};
  for (const key in obj1) {
    if (obj1[key] === obj2[key]) {
      res[key] = obj1[key];
    }
  }
  return res;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
