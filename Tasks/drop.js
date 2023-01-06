// Delete listed keys from dictionary

// Step 4
// Don't mutate incoming parameters

'use strict';

const drop = (dict, ...listedKeys) => {
  const res = {};
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (!listedKeys.includes(key)) {
      const value = dict[key];
      res[key] = value;
    }
  }
  return res;
};

require('../Tests/drop.js')(drop);
