// Finde an intersection of two dictionaries
'use strict';

function intersection(object1, object2) {
  const intersection = {};
  for (const key in object1) {
    if (object2[key]) {
      intersection[key] = object1[key];
    }
  }
  return intersection;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
