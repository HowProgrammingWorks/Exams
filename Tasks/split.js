// Split array into two parts

'use strict';

const splitArray = (index, array) => {
  const begin = array.slice(0, index);
  const len = array.length;
  array = array.slice(index, len);
  return [begin, array];
};

const result = splitArray(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
