'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (bytes) => {
  let exp = 0;
  let value = bytes;
  const max = SIZE_UNITS.length - 1;
  while (value >= 1000 && exp < max) {
    value /= 1000;
    exp++;
  }
  return `${value.toFixed()} ${SIZE_UNITS[exp]}`;
};

require('../Tests/size.js')(size);
