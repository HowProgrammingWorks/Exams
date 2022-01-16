'use strict';

// Find a difference between two dictionaries
const diff = (objectA, objectB) => {
  const result = {};

  for (const key in objectA) {
    if (objectA[key] === objectB[key]) continue;
    result[key] = objectA[key];
  }

  for (const key in objectB) {
  }

  return result;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
