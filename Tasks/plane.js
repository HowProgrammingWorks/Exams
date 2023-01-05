// Make nested array plane
'use strict';
const planedArray = (arr) => {
    const res = [];
    for(const value of arr) {
    if (Array.isArray(value)) {
    res.push(...planedArray(value));
    }else{
    res.push(value);
    }
  }
  return res;
};

require('../Tests/plane.js')(planedArray);
