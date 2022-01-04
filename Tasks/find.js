// Find key by value
'use strict';
const find=(object, rest) => {
   for (let name in object) {
      if (object[name]) == rest)  return name;
   }
}

const result = find({ a: 1, b: 2, c: 'hello', d: false }, 'hello');
console.log(result);
