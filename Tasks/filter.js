// Filter array by type name

// Step 2
// Add `const` and `let`

'use strict';

const Filter = (T, t) => {
  const remove = [];
  for (const C of T) {
    const x = T.indexOf(C);
    if (typeof T[x] !== t) {
      remove.unshift(x);
    }
  }
  for (const x of remove) T.splice(x, 1);
  return T;
};

require('../Tests/filter.js')(Filter);
