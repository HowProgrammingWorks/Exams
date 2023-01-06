// Split string by the first occurrence of separator

// Step 2.
// remove if ==== ''
// use B of a
'use strict';

const Parseip = (i) => {
  const B = i.split('.');
  if (B.length != 4) return;
  let j = 0;
  for (const b of B) {
    B[j] = parseInt(b);
    if (isNaN(B[j])) return;
    j++;
  }
  return B;
};

require('../Tests/ip.js')(Parseip);