'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
  const result = { ...obj1 };

  for (const key in obj2) {
    result[key] = obj2[key];
  }

  return result;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
