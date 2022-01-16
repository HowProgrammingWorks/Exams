'use strict';

// Find a difference between two dictionaries
const diff = (objectA, objectB) => {
  const result = {};

  for (const key of Object.keys(objectA)) {
    if (objectA[key] === objectB[key]) continue;
    result[key] = objectA[key];
  }

  for (const key of Object.keys(objectB)) {
    if (objectA[key] === objectB[key]) continue;
    result[key] = objectB[key];
  }

  return result;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
