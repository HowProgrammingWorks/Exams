// Reverse dict, exchange keys and values
'use strict';

const reverse = (obj) => {
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    const value = obj[key];
    obj[value] = key;
    delete obj[key];
  });
  return obj;
};

require('../Tests/reverse.js')(reverse);
