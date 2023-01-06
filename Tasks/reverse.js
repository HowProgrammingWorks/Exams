// Reverse dict, exchange keys and values
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
