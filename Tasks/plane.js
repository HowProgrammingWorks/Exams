'use strict';

const plane = function(arr) {
  const result = [];

  const closedPlane = arr =>{
    for(let item of arr){
      if (Array.isArray(item)) closedPlane(item);
      else result.push(item);
    }
    return result
  }

  return closedPlane(arr)
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
