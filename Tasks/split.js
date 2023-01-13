'use strict';

// Split an array into two parts

const splitArray = (splitPoint, array) => {
  const firstPart = array.splice(0, splitPoint);
  const secondPart = array.splice(-splitPoint);
  const res = [firstPart, secondPart];
  return res;
};

require('../Tests/split.js')(splitArray);
