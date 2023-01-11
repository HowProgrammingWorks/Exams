'use strict';
// Copy all values from dict except listed

const copyWithoutExceptions = (dict, ...exceptions) => {
  const result = {};
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (!exceptions.includes(key)) {
      result[key] = dict[key];
    }
  }
  return result;
};

require('../Tests/except.js')(copyWithoutExceptions);
