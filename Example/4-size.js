// Convert number to file size in bytes, kb, mb, and gb

// Step 4
//
// Add more units
// Remove ternary and `exp - 1`

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (bytes) => {
  if (bytes === 0) return '0 ' + SIZE_UNITS[0];
  const exp = Math.floor(Math.log(bytes) / Math.log(1000));
  const value = Math.round(bytes / 1000 ** exp);
  const unit = SIZE_UNITS[exp];
  return value.toString() + ' ' + unit;
};

require('../Tests/size.js')(size);
