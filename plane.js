'use strict';

// Make nested array plane

const Arrplane = function(arr) {
  const res = [];
  for(let i = 0; i < arr.length; i++){
    let value = arr[i];
    if (Array.isArray(value)) {
      res.push(...Arrplane(value));
    } else {
      res.push(value);
    }
  }
  return res
}

const result = Arrplane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
