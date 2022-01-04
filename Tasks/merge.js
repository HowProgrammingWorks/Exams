'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
  const result = {};
  for (const key in obj1) {
    result[key] = obj1[key];
  }

  for (const key in obj2) {
    result[key] = obj2[key];
  }

  return result;
};

// 1-line version of function
// const merge = (obj1, obj2) => ({ ...obj1, ...obj2 });

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
