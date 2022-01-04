'use strict';
// Merge two dictionaries

const mergeTwoObjects = (object1, object2) => {
  const mergedObject = {};
  return Object.assign(mergedObject, object1, object2);
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
