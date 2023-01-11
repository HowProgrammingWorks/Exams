// Filter array by type name

// Step 4
// Remove unneeded operations

'use strict';

const filter = (array, type) => {
  const filtered = [];
  for (const element of array) {
    if (typeof element === type) {
      filtered.push(element);
    }
  }
  return filtered;
};

require('../Tests/filter.js')(filter);
