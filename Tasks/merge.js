// Merge two dictionaries
'use strict';

const mergeTwoObjects = (obj1, obj2) => {
  const obj3 = {};
  for (let i in obj1) {
    obj3[i] = obj1[i];
  }
  for (let j in obj2) {
    obj3[j] = obj2[j];
  }
  return obj3;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
