'use strict';
// Merge two dictionaries

const merge = (obj1, obj2) => {
  const result = { ...obj1, ...obj2 };

  return result;
};

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
