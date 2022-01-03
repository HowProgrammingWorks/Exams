'use strict';
// Find first word with two identical letters

const zip = function(arrFirst = [], arrSecond = []) {
  const sliceLength = Math.min(arrFirst.length, arrSecond.length);
  const slicedBase = arrFirst.slice(0, sliceLength);
  return slicedBase.map((value, idx) => [value, arrSecond[idx]]);
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
