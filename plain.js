'use strict';

// Make nested array plane

const ArrPlain = function(arr) {
  const res = [];
  for(let i = 0; i < arr.length; i++){
    let value = arr[i];
    if (Array.isArray(value)) {
      res.push(...ArrPlain(value));
    } else {
      res.push(value);
    }
  }
  return res
}

const result = ArrPlain([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
