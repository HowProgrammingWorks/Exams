'use strict'
// Find a difference of two dictionaries

const diff = (object1, object2) => {
  const keys2 = Object.keys(object2);
  for (const attributeName of keys2) {
    delete object1[attributeName];
  }
  return object1;
}
const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
