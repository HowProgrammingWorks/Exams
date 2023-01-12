'use strict';

const copyExcept = (obj, ...exceptions) => {
  const result = {};
  const keys = Object.keys(obj);
  for (const key of keys) {
    if (!exceptions.includes(key)) {
      const value = obj[key];
      result[key] = value;
    }
  }
  return result;
};

require('../Tests/except.js')(copyExcept);
