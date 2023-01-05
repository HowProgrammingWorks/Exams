// Copy only listed values from dict
'use strict'

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);
  const result = {};

  for (let currentKey of keys)
    if (only.includes(currentKey))
      result[currentKey] = dictionary[currentKey];

  return result;
};

require('../Tests/only.js')(only);
