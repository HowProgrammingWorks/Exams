// Merge two dictionaries
'use strict';

const merge = (object1, object2) => {
  const res = {};
  const keys1 = Object.keys(object1);
  const keys2 = Object.keys(object2);
  for (const key of keys1) {
    res[key] = object1[key];
  }
  for (const key of keys2) {
    res[key] = object2[key];
  }
  return res;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
