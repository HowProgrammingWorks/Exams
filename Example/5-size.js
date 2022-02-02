// Convert number to file size in bytes, kb, mb, and gb

// Step 5
//
// Remove duplicates
// Extract serialization

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const sizeToString = (value, unit) => `${value} ${SIZE_UNITS[unit]}`;

const size = (bytes) => {
  if (bytes === 0) return sizeToString(bytes, 0);
  const exp = Math.floor(Math.log(bytes) / Math.log(1000));
  const value = Math.round(bytes / 1000 ** exp);
  return sizeToString(value, exp);
};

require('../Tests/size.js')(size);
