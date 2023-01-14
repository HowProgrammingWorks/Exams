// Find an intersection of two dictionaries

'use strict';

const intersection = (firstObj, secondObj) => {
  const result = {};
  const firstObjKeys = Object.keys(firstObj);
  for (const key of firstObjKeys) {
    if (firstObj[key] === secondObj[key]) {
      result[key] = firstObj[key];
    }
  }
  return result;
};

require('../Tests/intersection.js')(intersection);