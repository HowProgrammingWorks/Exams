// Split string by the first occurrence of separator

// Old one...
// Final ver -> '..\Solutions\ip.js'

// Step 1. 
// Use 'use strict'; 
// remove useless else 
'use strict';

const Parseip = (i) => {
  const a = [];
  if (i === '') return;
  const B = i.split('.');
  if (B.length != 4) return;
  let j = 0;
  for (const b of B) {
    a[j] = parseInt(b);
    if (isNaN(a[j])) return;
    j++;
  }
  return a;
};

require('../Tests/ip.js')(Parseip);