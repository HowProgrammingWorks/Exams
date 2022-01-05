// Find key by value
'use strict';

const find = (object, value) => {
   const keys = Obgect.keys(object);
   for (const name of object) {
      if (object[name] === value) return name;
   }
};

const result = find({ a: 1, b: 2, c: 'hello', d: false }, 'hello');
console.log(result);
