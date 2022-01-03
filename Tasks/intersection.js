'use strict';

// Finde an intersection of two dictionaries

const intersection = (object1, object2) => {
  let result = {};
  const keys = Object.keys(object1);
  for (const key of keys) {
    if (key !== '' && object2[key]) {
      result[key] = object1[key];
    }
  }
  return result;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
