// Copy only listed values from dict

'use strict';

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);
  for (const currentKey of keys) {
    const condition = only.includes(currentKey);
    if (!condition) {
      delete dictionary[currentKey];
    }
  }
  return dictionary;
};

require('../Tests/only.js')(only);
