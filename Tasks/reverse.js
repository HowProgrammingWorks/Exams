// Reverse dict, exchange keys and values
'use strict';

const reverse = obj => {
  const entries = Object.entries(obj);
  const entriesRev = entries.map(
    item => item.reverse()
  );

  return Object.fromEntries(entriesRev);
};

require('../Tests/reverse.js')(reverse);
