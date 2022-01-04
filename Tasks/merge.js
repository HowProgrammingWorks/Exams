// Merge two dictionaries
'use strict';

const merge = (object1, object2) => {
  const res = {};
  const keys1 = Object.keys(object1);
  const keys2 = Object.keys(object2);
  for (const key in object1) {
    res[key] = object1[key];
  }
  for (const key in object2) {
    res[key] = object2[key];
  }
  return object1, object2, res;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
