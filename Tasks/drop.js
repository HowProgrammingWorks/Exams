// Delete listed keys from dictionary

// Step 3
// Use `for (...of...)` instead of `forEach`

'use strict';

const drop = (dict, ...listedKeys) => {
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (listedKeys.includes(key)) {
      delete dict[key];
    }
  }
  return dict;
};

require('../Tests/drop.js')(drop);
