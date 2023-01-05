// Copy only listed values from dict
'use strict'

const only = (dictionary, ...only) => {
  const keys = Object.keys(dictionary);

  for (let key of keys)
    if (!only.includes(key)) delete dictionary[key];

  return dictionary;
};

require('../Tests/only.js')(only);
