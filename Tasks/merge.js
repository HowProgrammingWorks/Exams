// Merge two dictionaries
'use strict';

const mergeTwoObjects = (obj1, obj2) => {
  const obj3 = {};
  for (const key in obj1) {
    obj3[key] = obj1[key];
  }
  for (const key in obj2) {
    obj3[key] = obj2[key];
  }
  return obj3;
};

const result = mergeTwoObjects({ a: 'uno', b: 'due' }, { c: 'tre', d: 'cua' });
console.log(result);
