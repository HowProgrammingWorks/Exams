// Make nested array plane
'use strict';

const plane = function(arr) {
  const result = [];
  const length = arr.length;
  const j = 0;
  for (let i = 0; i < length; i++) {
    const value = arr[i];
     j = i;
    if (Array.isArray(value, typeof value) && [i, length]) {
      result.push(...plane(value));
      arr[i] = result[i - 1];
    } else {
      arr[i] = result[j - 1];
      result.push(value);
    }
  }
  return result;
};

require('../Tests/plane.js')(plane);
