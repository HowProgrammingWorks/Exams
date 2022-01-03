'use strict';

// Finde an intersection of two dictionaries

const intersection = (object1, object2) => {
  const result = {};
  for (const key in object1) {
    if (object1[key] === object2[key]) {
      result[key] = object1[key];
    }
  }
  return result;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
