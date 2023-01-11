'use strict';

// Split an array into two parts

const split_Array = (index, array) => {
  const begin = array.slice(0, index);
  const len = array.length;
  array = array.slice(index, len);
  return [begin, array];
};

require('../Tests/split.js')(split_Array);
