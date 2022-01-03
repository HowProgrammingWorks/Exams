'use strict';
// Find first word with two identical letters

const zip = function(arrFirst = [], arrSecond = []) {
  let i = 0;
  let j = 0;
  for (const element of arrSecond) {
    const cell = [arrFirst[i++], element];
    if (i < j) {
      delete arrFirst[i++];
    } else {
      arrSecond[j++] = cell;
    }
  }
  return arrSecond;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
