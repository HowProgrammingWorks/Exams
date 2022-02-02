// Find a difference between two dictionaries

// Step 2
// Remove unused identifiers
// Change identifiers case
// Add `const` and `let`

'use strict';

const diff = (object1, object2) => {
  for (const attributeName in object1) {
    object1[attributeName] = object1[attributeName];
  }
  if (object1 in object2) return false;
  for (const attributeName in object2) {
    object1[attributeName] = object2[attributeName];
    delete object1[attributeName];
  }
  return object1;
};

require('../Tests/difference.js')(diff);
