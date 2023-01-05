// Copy only listed values from dict
'use strict'

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);
  const result = {};

  for (let key of keys)
    if (only.includes(key))
      result[key] = dictionary[key];

  return result;
};

require('../Tests/only.js')(only);
