// Find an intersection of two dictionaries

'use strict';

const intersection = (object1, object2) => {
  const intersecObj = {};
  const firstKeys = Object.keys(object1);
  for (const key of firstKeys) {
    if (object1[key] === object2[key]) {
      intersecObj[key] = object1[key];
    }
  }
  return intersecObj;
};

require('../Tests/intersection.js')(intersection);
