'use strict';
// Make nested array plane

const const_plane = (arr) => {
  const res=[];
  for(const i of arr){
    if (Array.isArray(i)) {
    res.push(...const_plane(i));
    }else{
    res.push(i);
    };
  };
  return res
}

require('../Tests/plane.js')(const_plane);
