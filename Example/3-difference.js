// Find a difference between two dictionaries

// Step 3
// Remove senseless blocks

'use strict';

const diff = (object1, object2) => {
  for (const attributeName in object2) {
    delete object1[attributeName];
  }
  return object1;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
