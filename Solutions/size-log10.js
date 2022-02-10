'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (bytes) => {
  const exp = bytes && Math.floor(Math.log10(bytes) / 3);
  const value = Math.round(bytes / 1000 ** exp);
  return `${value} ${SIZE_UNITS[exp]}`;
};

require('../Tests/size.js')(size);
