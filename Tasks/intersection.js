// Find an intersection of two dictionaries
'use strict';

const intersection = (firstObj, secondObj) => {
  const result = {};
  const firstObjKeys = Object.keys(firstObj);
  for (const key of firstObjKeys) {
    if (firstObj[key] === secondObj[key]) {
      secondObj[key] = firstObj[key];
    } else {
      delete firstObj[key];
    }
  }
  return firstObj;
};

require('../Tests/intersection.js')(intersection);