// Split an array into two parts
'use strict';

const splitArray = (divider, array) => {
  const START = 0;
  const firstArray = array.slice(START, divider);
  const end = array.length;
  const secondArray = array.slice(divider, end);
  return [firstArray, secondArray];
};

require('../Tests/split.js')(splitArray);
