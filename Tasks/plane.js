'use strict';

const plane = (arr) => arr.flatMap( element => {
    if (Array.isArray(element)) {
      return plane(element);
    }
    return element;
  });


const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
