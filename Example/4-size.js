// Convert number to file size in bytes, kb, mb, and gb

// Step 4
//
// Add more units
// Remove ternary and `exp - 1`

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (size) => {
  if (size === 0) return '0';
  const exp = Math.floor(Math.log(size) / Math.log(1000));
  const value = Math.round(size / 1000 ** exp);
  const unit = SIZE_UNITS[exp];
  return value.toString() + ' ' + unit;
};

const result = size(123456);
console.log(result);
