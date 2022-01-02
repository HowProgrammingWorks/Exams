// Copy all listed keys from dictionary
'use strict';

function take(object, ...keys) {
  for (const key in object) {
    if (!keys.includes(key)) {
      delete object[key];
    }
  }
  return object;
}

const result = take({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'c');
console.log(result);
