'use strict';
// Deduplicate values in array

const leaveUniqueValues = function(array) {
  if (!Array.isArray(array)) return;

  const uniqueSet = new Set(array);
  const uniqueArray = Array.from(uniqueSet);

  return uniqueArray;
};

const result = eaveUniqueValues([1, 2, 1, 3, 1, 4]);
console.log(result);
