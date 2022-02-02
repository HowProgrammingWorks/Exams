// Convert number to file size in bytes, kb, mb, and gb

// Step 6
//
// Optimize inverse function for power

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const sizeToString = (value, unit) => `${value} ${SIZE_UNITS[unit]}`;

const size = (bytes) => {
  if (bytes === 0) return sizeToString(bytes, 0);
  const exp = Math.floor(Math.log10(bytes) / 3);
  const value = Math.round(bytes / 1000 ** exp);
  console.log({ exp, log10: Math.log10(bytes), value });
  return sizeToString(value, exp);
};

require('../Tests/size.js')(size);
