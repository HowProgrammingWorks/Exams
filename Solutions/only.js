// Copy only listed values from dict
'use strict'

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);
  keys.forEach((key) => {
    if (only.includes(key)) {
    } else {
      delete dictionary[key];
    }
  });
  return dictionary;
};

require('../Tests/only.js')(only);
