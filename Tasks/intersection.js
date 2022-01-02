// Finde an intersection of two dictionaries
'use strict';

function intersection(object1, object2) {
  const firstKeys = Object.keys(object1);
    for (const key of firstKeys) {
      if (key !== '' && object2[key]) {
        object2[key] = object1[key];
      } else {
          delete object1[key];
        }
    }
  return object1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
