// Convert number to file size in bytes, kb, mb, and gb

// Step 8
//
// Use while instead of log

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (bytes) => {
  let e = 0;
  let n = bytes;
  while (n >= 1000) {
    n /= 1000;
    e++;
  }
  return `${n.toFixed()} ${SIZE_UNITS[e]}`;
};

require('../Tests/size.js')(size);
