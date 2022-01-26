// Find a difference between two dictionaries

// Step 3
// Don't mutate incoming parameters

'use strict';

const diff = (object1, object2) => {
  const result = {};
  for (const name of Object.keys(object1)) {
    if (object1[name] !== object2[name]) {
      result[name] = object1[name];
    }
  }
  return result;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
