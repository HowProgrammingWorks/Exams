// Reverse dict, exchange keys and values
'use strict';

const reverse = (obj) => {
  const entries = Object.entries(obj);
  entries.map(
    item => item.reverse()
  );
  return obj;
};

require('../Tests/reverse.js')(reverse);
