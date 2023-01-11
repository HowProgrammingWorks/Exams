// Filter array by type name

// Step 3
// Improve naming

'use strict';

const filter = (array, type) => {
  const removed = [];
  for (const element of array) {
    const current = array.indexOf(element);
    if (typeof array[current] !== type) {
      removed.unshift(current);
    }
  }
  for (const element of removed) array.splice(element, 1);
  return array;
};

require('../Tests/filter.js')(filter);
