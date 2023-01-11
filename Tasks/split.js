'use strict';

// Split an array into two parts

const splitArray = (splitPoint, array) => {
  const begin = array.splice(0, splitPoint);
  array = array.splice(-splitPoint);
  return [begin, array];
};

require('../Tests/split.js')(splitArray);
