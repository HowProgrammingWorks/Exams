'use strict';

// Function intersection
// Returns a new object with all the keys and values which are in both object1 and object2
const intersection = (object1, object2) => {
  const object1Keys = Object.keys(object1);
  const intersected = {};
  for (const key of object1Keys) {
    if (key && object2[key] === object1[key]) {
      intersected[key] = object1[key];
    }
  }
  return intersected;
};

const result1 = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
const result2 = intersection({ a: 'eins', b: 'zwei', c: 'drei' }, { a: 'eins', b: 'zwei', c: 'drei' });
const result3 = intersection({ a: 'ichi', b: 'ni' }, { c: 'san', d: 'yon' });

console.log(result1);
console.log(result2);
console.log(result3);
