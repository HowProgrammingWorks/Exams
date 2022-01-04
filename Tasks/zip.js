'use strict';
// Find first word with two identical letters

const zip = (...arrays) => {
  const reduceToMinLength = (prev, curr) => Math.min(prev, curr.length);

  const sliceLength = arrays.reduce(reduceToMinLength, arrays[0].length);
  const indices = [...Array(sliceLength).keys()];
  return indices.map((idx) => arrays.map((array) => array[idx]));
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
