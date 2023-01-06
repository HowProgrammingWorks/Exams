// Return an array without duplicates

'use strict';

const distinct = (arr) => {
  const newArr = [];
  arr.forEach((item) => {
    if (newArr.includes(item)) {
      delete arr[item];
    } else {
      newArr.push(item);
    }
  });
  return arr;
};

require('../Tests/distinct.js')(distinct);
