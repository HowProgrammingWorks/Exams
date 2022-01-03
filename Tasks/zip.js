// Find first word with two identical letters
'use strict';

const zip = (a, b) => {
  let i = 0;
  let j = 0;
  for (const x of b) {
    const CELL = [a[i++], x];
    if (i < j) {
      delete a[i++];
    } else {
      b[j++] = CELL;
    }
  }
  return b;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
