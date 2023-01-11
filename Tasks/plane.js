// Make nested array plane
'use strict';

const plane = (arr) => {
  const result = [];
  const length = arr.length;
  let value = 0;
  for (let i = 0; i < length; i++) {
    value = arr[i];
    (Array.isArray(value)) ? result.push(...plane(value)) : result.push(value);
  }
  return result;
};

require('../Tests/plane.js')(plane);
