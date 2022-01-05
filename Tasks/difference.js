// Find a difference of two dictionaries
'use strict';

const dictDifference = (obj1, obj2) => {
  const clone1 = {};
  const keys1 = Object.keys(obj1);
  for (const key of keys1) {
    clone1[key] = obj1[key];
  }

  const keys2 = Object.keys(obj2);
  for (const key of keys2) {
    delete clone1[key];
  }
  return clone1;
};

const dict1 = { a: 'uno', b: 'due' };
const dict2 = { a: 'uno', c: 'tre' };
const result = dictDifference(dict1, dict2);
console.log({
  dict1,
  dict2,
  'dictionary difference': result
});
