// Copy all listed keys from dictionary
'use strict';

const take = (object, ...keys) => {
  const result = {};
  for (const [key, value] of Object.entries(object)) {
    if (keys.includes(key)) {
      result[key] = value;
    }
  }
  return result;
};

const result = take({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'c');
console.log(result);
