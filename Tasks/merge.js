'use strict';

// Merge two dictionaries

const merge = (function merge(object1, object2) {
  const object3 = { ...object1 };
  for (const key in object2) {
    (object3[key] == object2[key]);
    object3[key] = object2[key];
  }
  return object1, object2, object3;
});

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
