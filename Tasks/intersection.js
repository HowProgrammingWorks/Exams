// Find an intersection of two dictionaries

//change some variables

'use strict';
const intersection = (object1, object2) => {
  const objectKeys = Object.keys(object1);
  for (const key of objectKeys) {
    if (object1[key] === object2[key]) {
      object2[key] = object1[key];
    } else {
      delete object1[key];
    }
  }
  return object1;
};

require('../Tests/intersection.js')(intersection);
