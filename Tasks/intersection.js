// Finde an intersection of two dictionaries
'use strict';

const intersection = (obj1, obj2) => {
  const intersec = {};
  const firstKeys = Object.keys(obj1);
  for (const key of firstKeys) {
    if (obj1[key] === obj2[key]) {
      intersec[key] = obj1[key];
    }
  }
  return intersec;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
