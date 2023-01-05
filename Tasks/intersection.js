// Find an intersection of two dictionaries
'use strict';
const intersection = (object1, object2) => {
  const object1Keys = Object.keys(object1);
  for (const key of object1Keys) {
    if (object2[key] === object1[key]) {
      object2[key] = object1[key];
    } else {
      delete object1[key];
    }
  }
  return object1;
};

require('../Tests/intersection.js')(intersection);
