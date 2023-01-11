'use strict';

// Split an array into two parts

const splitArray = (splitPoint, array) => {
  const begin = array.slice(0, splitPoint);
  const len = array.length;
  array = array.slice(splitPoint, len);
  return [begin, array];
};

require('../Tests/split.js')(splitArray);
