// Filter array by type name

// Step 1
// Add 'use strict'
// Fix indentations

'use strict';

Filter = (T, t) => {
  remove = [];
  for (C of T) {
    x = T.indexOf(C);
    if (typeof T[x] !== t) {
      remove.unshift(x);
    }
  }
  for (x of remove) T.splice(x, 1);
  return T;
};

require('../Tests/filter.js')(Filter);
