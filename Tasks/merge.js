'use strict';
// Merge two dictionaries

const mergeTwoObjects = (object1, object2) => {
  const mergedObject = {};
  for (const key in object1) {
    mergedObject[key] = object1[key];
  }
  for (const key in object2) {
    mergedObject[key] = object2[key];
  }
  return object1, object2, mergedObject;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
