// Reverse dict, exchange keys and values

// Reverse is fixed. Test is passed: 4 of 4

'use strict';

const reverse = (obj) => {
  const res = {};
  const keys = Object.keys(obj);
  for (const key of keys) {
    const value = obj[key];
    res[value] = key;
  }
  return res;
};

require('../Tests/reverse.js')(reverse);
