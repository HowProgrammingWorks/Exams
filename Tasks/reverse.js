// Reverse dict, exchange keys and values
'use strict';

const reverse = (obj) => {
  const entries = Object.entries(obj);
  entries.map((_) => {
    const v1 = obj[_];
    obj[v1] = _;
    delete obj[_];
  });
  return obj;
};

require('../Tests/reverse.js')(reverse);
