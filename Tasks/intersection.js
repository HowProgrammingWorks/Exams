'use strict';
// Finde an intersection of two dictionaries

function intersection(first, second) {
  const firstKeys = Object.keys(first);
  for (const attributeName of firstKeys) {
    if (attributeName !== '' && second[attributeName]) {
      second[attributeName] = first[attributeName];
    } else {
      delete first[attributeName];
    }
  }
  return first;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
