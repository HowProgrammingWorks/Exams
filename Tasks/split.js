'use strict';

// Split array into two parts

const splitArray = (splitIndex, array) => {
  const part1 = array.slice(0, splitIndex);
  const arrLen = array.length;
  const part2 = array.slice(spplitIndex, arrLen);
  return [part1, part2];
};

const result = splitArray(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
