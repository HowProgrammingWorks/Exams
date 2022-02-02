// Convert number to file size in bytes, kb, mb, and gb

// Step 3
//
// Extract units to constants collection
// Use collection instead of if-statements

'use strict';

const SIZE_UNITS = ['kb', 'mb', 'gb'];

const size = (bytes) => {
  if (bytes === 0) return '0 byte';
  const exp = Math.floor(Math.log(bytes) / Math.log(1000));
  const value = Math.round(bytes / 1000 ** exp);
  const unit = exp === 0 ? 'byte' : SIZE_UNITS[exp - 1];
  return value.toString() + ' ' + unit;
};

require('../Tests/size.js')(size);
