// Reverse dict, exchange key and value
'use strict';

const invertDict = (dict) => {
  const keys = Object.keys(dict);
  for (const item of keys) {
    keys[item] = dict.pop();
  }
  return keys;
};

const result = invertDict([100, 200, 300, 400]);
console.log(result);
