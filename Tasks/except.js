'use strict'
// Copy all values from dict except listed

const except = (obj, ...excision) => {
  let improvedObj = {};
  for (const key of Object.keys(obj)) {
    if (!excision.includes(key)) improvedObj[key] = obj[key];
  }
  return improvedObj;
};

console.log(except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd'));
