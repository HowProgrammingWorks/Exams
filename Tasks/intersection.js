'use strict';
// Finde an intersection of two dictionaries

function intersection(first, second) {
  const firstKeys = Object.keys(first);
  const res = {};
  for (const attributeName of firstKeys) {
    if (attributeName !== '' && second[attributeName]) {
      res[attributeName] = first[attributeName];
    } else {
      delete res[attributeName];
    }
  }
  return res;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
