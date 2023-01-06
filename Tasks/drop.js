// Delete listed keys from dictionary

// Step 4
// Don't mutate incoming parameters

'use strict';

const drop = (dict, ...listedKeys) => {
  const res = {};
  const keys = Object.keys(dict);
  for (const key of keys) {
    const statement = listedKeys.includes(key);
    if (!statement) res[key] = dict[key];
  return res;
};

require('../Tests/drop.js')(drop);
