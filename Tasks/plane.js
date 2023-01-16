'use strict';
// Make nested array plane

const planeArray = (arr) => {
  const res = [];
  for (const element of arr) {
    if (Array.isArray(element)) {
      res.push(...planeArray(element));
    } else {
      res.push(element);
    }
  }
  return res;
};

require('../Tests/plane.js')(planeArray);
