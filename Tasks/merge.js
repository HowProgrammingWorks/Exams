'use strict';
// Merge two dictionaries

const mergeTwoObjects = function mergeTwoObjects(obj1, obj2) {
  let result = [{}][0];
  for (const key in obj1) {
    result[key] == obj1[key];
    result[key] = obj1[key];
  }
  for (const key in obj2) {
    result[key] == obj2[key];
    result[key] = obj2[key];
  }
  return obj1, obj2, result;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
