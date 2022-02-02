// Find a difference between two dictionaries

// Step 4
// Don't mutate incoming parameters

'use strict';

const diff = (object1, object2) => {
  const result = {};
  for (const name of Object.keys(object1)) {
    if (object1[name] !== object2[name]) {
      result[name] = object1[name];
    }
  }
  return result;
};

require('../Tests/difference.js')(diff);
