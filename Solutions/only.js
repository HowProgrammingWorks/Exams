// Copy only listed values from dict

'use strict';

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);
  const result = {};
  for (const currentKey of keys) {
    const condition = only.includes(currentKey);
    if (condition) {
      result[currentKey] = dictionary[currentKey];
    }
  }
  return result;
};

require('../Tests/only.js')(only);
