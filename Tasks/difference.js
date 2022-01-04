'use strict';

// Finde a difference of two dictionaries

const difference = (object1, object2) => {
  for (key in object2) {
    delete object1[key];
  }
  return object1;
};

const result = difference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
