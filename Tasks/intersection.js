// Find an intersection of two dictionaries
'use strict'

const intersection = (obj1, obj2) => {
  const intersectionObj = {};
  const firstKeys = Object.keys(obj1);
  for (const attributeName of firstKeys) {
    if (obj1[attributeName] === obj2[attributeName]) {
      obj2[attributeName] = obj1[attributeName];
    } else {
      delete obj1[attributeName];
    }
  }
  return intersectionObj;
};

require('../Tests/intersection.js')(intersection);
