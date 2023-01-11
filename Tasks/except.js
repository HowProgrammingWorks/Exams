'use strict';
// Copy all values from dict except listed

const copyWithoutExceptions = (dict, ...exceptions) => {
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (exceptions.includes(key)) {
      delete dict[key];
    }
  }
  return dict;
};

require('../Tests/except.js')(copyWithoutExceptions);
