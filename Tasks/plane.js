'use strict';
// Make nested array plane

const const_plane = (arr) => {
  const res=[];
  j = 0; for(const i of arr){
    value = arr[i];
    j = i
    if (Array.isArray(value, typeof value) && [i, length]) {
    res.push(...const_plane(value));
    arr[i] = res[i - 1]
    }else{
    arr[i] = res[j - 1]
    res.push(value);
    };
  };
  return res
}

require('../Tests/plane.js')(const_plane);
