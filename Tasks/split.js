'use strict';

// Split array into two parts

const splitArray = (splitIndex, array) => {
  const part1 = array.slice(0, splitIndex);
  const arrLen = array.length;
  const part2 = array.slice(splitIndex, arrLen);
  const splittedArr = [part1, part2];
  return splittedArr;
};

const result = splitArray(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
