// Find an intersection of two dictionaries
'use strict'

const intersection = (obj1, obj2) => {
  const result = {};
  const firstKeys = Object.keys(obj1);
  for (const key of firstKeys) {
    if (obj1[key] === obj2[key]) {
      result[key] = obj1[key];
    }
  }
  return result;
};

require('../Tests/intersection.js')(intersection);
