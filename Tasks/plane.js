'use strict';

const plane = function(arr, result=[]) {
  for(let item of arr){
    if (Array.isArray(item)) result.push(...plane(item));
    else result.push(item);
  }
  return result
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
