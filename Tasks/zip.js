// Find first word with two identical letters
'use strict';

const zip = (a, b) => {
  const resLength = (a.length > b.length) ? b.length : a.length;
  const res = [];
  for (let i = 0; i < a.length; i++) {
    const first = a[i];
    const second = b[i];
    const cell = [first, second];
    res.push(cell);
  }
  return res;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
