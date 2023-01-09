// Find an intersection of two dictionaries
'use strict'

const intersection = (obj1, obj2) => {
  const intersectionObj = {};
  const firstKeys = Object.keys(obj1);
  for (const key of firstKeys) {
    if (obj1[key] === obj2[key]) {
      intersectionObj[key] = obj1[key];
    }
  }
  return intersectionObj;
};

require('../Tests/intersection.js')(intersection);
