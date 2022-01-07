// Convert number to file size in bytes, kb, mb, and gb

// Step 2
//
// Remove unneeded blocks, for example we do not need else here
// Remove repeating code

'use strict';

const size = (size) => {
  if (size === 0) return '0';
  const exp = Math.floor(Math.log(size) / Math.log(1000));
  const value = Math.round(size / 1000 ** exp);
  let unit = ' byte';
  if (exp === 1) unit = ' kb';
  if (exp === 2) unit = ' mb';
  if (exp === 3) unit = ' gb';
  return value.toString() + unit;
};

const result = size(123456);
console.log(result);
