// Make nested array plane
'use strict';

const plane = (arr) => {
  let res = [];

  for (const element of arr) {
    if (Array.isArray(element)) {
      res = res.concat(plane(element));
    } else {
      res.push(element);
    }
  }

  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
