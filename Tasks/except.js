// Copy all values from dict except listed

'use strict';

const copyExcept = (obj, ...exceptions) => {
  const copiedDict = {};
  const keys = Object.keys(obj);
  for (const key of keys) {
    if (!exceptions.includes(key)) {
      copiedDict[key] = obj[key];
    }
  }
  return copiedDict;
};

require('../Tests/except.js')(copyExcept);
