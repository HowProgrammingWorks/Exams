'use strict';

// Find a difference between two dictionaries
const diff = (objectA, objectB) => {
  const result = { ...objectA, ...objectB };
  for (const key of Object.keys(result)) {
    if (objectA[key] === objectB[key]) delete result[key];
  }
  return result;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
