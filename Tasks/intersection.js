// Find an intersection of two dictionaries

// Step 4
// Don't mutate incoming parameters

'use strict';

const intersection = (obj1, obj2) => {
  const res = {};
  const keys = Object.keys(obj1);
  for (const key of keys) {
    const value = obj1[key];
    if (obj2[key] === value) {
      res[key] = value;
    }
  }
  return res;
};

require('../Tests/intersection.js')(intersection);
