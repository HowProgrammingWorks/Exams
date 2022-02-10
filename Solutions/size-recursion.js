'use strict';

const SIZE_UNITS = ['byte', 'kb', 'mb', 'gb', 'tb', 'pb', 'eb', 'zb', 'yb'];

const size = (value, exp = 0) =>
  value < 1000 || exp === SIZE_UNITS.length - 1
    ? `${value.toFixed()} ${SIZE_UNITS[exp]}`
    : size(value / 1000, ++exp);

require('../Tests/size.js')(size);
