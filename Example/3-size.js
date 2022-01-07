// Convert number to file size in bytes, kb, mb, and gb

// Step 3
//
// Extract units to constants collection
// Use collection instead of if-statements

'use strict';

const SIZE_UNITS = ['kb', 'mb', 'gb'];

const size = (size) => {
  if (size === 0) return '0';
  const exp = Math.floor(Math.log(size) / Math.log(1000));
  const value = Math.round(size / 1000 ** exp);
  const unit = exp === 0 ? 'byte' : SIZE_UNITS[exp - 1];
  return value.toString() + ' ' + unit;
};

const result = size(123456);
console.log(result);
