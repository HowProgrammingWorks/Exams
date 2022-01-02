// Make nested array plane
'use strict';

const_plane = function(arr) {
  const res = [];
 const  j = 0;
 const length = arr.length;
 for(let i = 0; i < length; i++){
    const value = arr[i];
    if (Array.isArray(value)) {
    res.push(...plane(value));
    }else{
    res.push(value);
    }
  }
  return res;
}

const result = const_plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
