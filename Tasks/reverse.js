// Reverse dict, exchange keys and values
'use strict';

const reverse = (obj) => {
  const entries = Object.entries(obj);
  const entriesRev = entries.map(
    item => item.reverse()
  );
  
  const result = Object.fromEntries(entriesRev);
  return result;
};

require('../Tests/reverse.js')(reverse);
