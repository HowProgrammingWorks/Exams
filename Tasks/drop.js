// Delete listed keys from dictionary

// Step 2
// Add `const`
// Change identifiers names and case

'use strict';

const drop = (dict, ...listedKeys) => {
  const keys = Object.keys(dict);
  keys.forEach(
    (x) => {
      if (listedKeys.includes(x)) {
        delete dict[x];
      }
    }
  );
  return dict;
};

require('../Tests/drop.js')(drop);
