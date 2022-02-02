// Convert number to file size in bytes, kb, mb, and gb

// Step 9
//
// Implement with recursion

'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (n, e = 0) =>
  (n < 1000 ? `${n.toFixed()} ${SIZE_UNITS[e]}` : size(n / 1000, ++e));

require('../Tests/size.js')(size);
