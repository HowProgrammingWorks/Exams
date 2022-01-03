'use strict';
// Find first word with two identical letters

const zip = function(arrFirst = [], arrSecond = []) {
  let i = 0;
  let j = 0;
  const res = [];
  for (const x of arrSecond) {
    const cell = [arrFirst[i++], x];
    res.push(cell);
    if (i < j) {
      i++;
    } else {
      j++;
    }
  }
  return res;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
