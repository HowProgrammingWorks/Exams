// Reverse dict, exchange keys and values
'use strict';

const reverse = (obj) => {
  const res = {};
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    const value = obj[key];
    res[value] = key;
  });
  return res;
};

require('../Tests/reverse.js')(reverse);
