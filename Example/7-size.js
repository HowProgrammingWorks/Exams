// Convert number to file size in bytes, kb, mb, and gb

// Step 7
//
// Use .length instead of inverse function for power
// Back to a single function

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (bytes) => {
  const digits = bytes.toString().length;
  const exp = Math.floor((digits - 1) / 3);
  const value = (bytes / 1000 ** exp).toFixed();
  return `${value} ${SIZE_UNITS[exp]}`;
};

require('../Tests/size.js')(size);
