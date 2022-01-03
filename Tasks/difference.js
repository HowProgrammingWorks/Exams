"use strict";
// Find a difference of two dictionaries

const diff = (object1, object2) => {
  for (const key in object2) {
    delete object1[key];
  }
  return object1;
}
const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);