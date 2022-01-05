// Find a difference of two dictionaries
'use strict';

const dictDifference = (obj1, obj2) => {
  const result = {};
  const keys1 = Object.keys(obj1);
  for (const key of keys1) {
    if (!obj2[key]) {
      result[key] = obj1[key];
    }
  }
  return result;
};

const dict1 = { a: 'uno', b: 'due' };
const dict2 = { a: 'uno', c: 'tre' };
const result = dictDifference(dict1, dict2);
console.log({
  dict1,
  dict2,
  'dictionary difference': result
});
