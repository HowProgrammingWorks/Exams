'use strict';
// Find first word with two identical letters

const zip = function(arrFirst = [], arrSecond = []) {
  const res = [];
  for (let i = 0; i < arrFirst.length && i < arrSecond.length; i++) {
    const cell = [arrFirst[i], arrSecond[i]];
    res.push(cell);
  }
  return res;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
