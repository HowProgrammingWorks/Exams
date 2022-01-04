'use strict';

// Finde an intersection of two dictionaries

const intersection = (object1, object2) => {
  const result = {};
  const keys = Object.keys(object1);
  for (const key of keys) {
    const value = object1[key];
    if (object2[key] === value) {
      result[key] = value;
    }
  }
  return result;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
