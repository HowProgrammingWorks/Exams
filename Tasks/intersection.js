'use strict';

// Finde an intersection of two dictionaries
const intersection = (object1, object2) => {
  const OBJECT1_KEYS = Object.keys(object1);
  const intersected = {};
  for (const key of OBJECT1_KEYS) {
    if (key && object2[key] === object1[key]) {
      intersected[key] = object1[key];
    }
  }
  return intersected;
};

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
