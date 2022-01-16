'use strict';

// Find a difference between two dictionaries
const diff = (objectA, objectB) => {
  for (const key in objectA) {
    objectA[key] = objectA[key];
  }

  for (const key in objectB) {
    objectA[key] = objectB[key];
    delete objectA[key];
  }

  return objectA;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
