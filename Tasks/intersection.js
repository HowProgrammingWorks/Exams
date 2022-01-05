'use strict'
// Find an intersection of two dictionaries

const intersection = (object1, object2) => {
  const firstKeys = Object.keys(object1);
  for (const attributeName of firstKeys) {
    if (attributeName !== '' && object2[attributeName]) {
      object2[attributeName] = object1[attributeName];
    } else {
      delete object1[attributeName];
    }
  }
  return object1;
}
const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
