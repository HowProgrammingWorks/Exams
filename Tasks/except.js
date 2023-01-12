'use strict';

const copyExcept = (obj, ...exceptions) => {
const keys = Object.keys(obj);
  for (const key of keys) {
    if (exceptions.includes(key)) {
      delete obj[key];
    }
  }
  return obj;
};

require('../Tests/except.js')(copyExcept);
