'use strict';
// Merge two dictionaries

const mergeTwoObjects = (object1, object2) => {
  const mergedObject = {};
  const key1 = Object.keys(object1);
  const key2 = Object.keys(object2);
  for (const key of key1) {
    mergedObject[key] = object1[key];
  }
  for (const key of key2) {
    mergedObject[key] = object2[key];
  }
  return mergedObject;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
