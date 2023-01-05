// Make nested array plane
'use strict';
const planedArray = (arr) => {
    const res = [];
    let j = 0; 
    for(let i = 0, length = arr.length; i < length; i++){
    const value = arr[i];
    j = i
    if (Array.isArray(value)) {
    res.push(...planedArray(value));
    arr[i] = res[i - 1]
    }else{
    arr[i] = res[j - 1]
    res.push(value);
    };
  };
  return res
};

require('../Tests/plane.js')(planedArray);
