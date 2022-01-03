// Reverse dict, exchange key and value
'use strict';

const invert = array => {
  const keys = Object.keys(array);
  keys.forEach(item => {
    keys[item] = array.pop();
  });
  return keys;
};

const result = invert([100, 200, 300, 400]);
console.log(result);
