// Make nested array plane
'use strict';

const plane = (arr) => {
  const result = [];
  for (const value of arr) {
    Array.isArray(value) ? result.push(...plane(value)) : result.push(value);
  }
  return result;
};

require('../Tests/plane.js')(plane);
