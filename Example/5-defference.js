// Find a difference between two dictionaries

// Step 5
// Don't mutate incoming parameters

'use strict';

const diff = (object1, object2) => {
  const result = {};
  for (const name of Object.keys(object1)) {
    const value = object1[name];
    if (object2[name] !== value) {
      result[name] = value;
    }
  }
  return result;
};

require('../Tests/difference.js')(diff);
