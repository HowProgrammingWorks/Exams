'use strict';

// Merge two dictionaries

const mergeTwoObjects = (obj1, obj2) => {
  const result = {};
  const keys1 = Object.keys(obj1);
  const keys2 = Object.keys(obj2);

  for (const key in obj1) {
    result[key] = obj1[key];
  }
  for (const key in obj2) {
    result[key] = obj2[key];
  }
  return result;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
