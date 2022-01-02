'use strict';
// Merge two dictionaries

const mergeTwoObjects = (object1, object2) => {
  const mergedObject = {};
  const res = Object.assign(mergedObject, object1, object2);
  return res;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
