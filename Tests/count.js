'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 1, b: 'two', c: 3, d: 4 }], 8],
  [[{ a: 1, b: 'two', c: -3, d: 4 }], 2],
  [[{ a: 0, b: 'two', c: 0, d: -1 }], -1],
  [[{ a: -1, b: 'two', c: -3, d: -4 }], -8],
  [[{ a: 1, b: 'two', c: -1, d: 0 }], 0],
  [[{ a: '1', b: 'two', c: 3, d: 4 }], 7],
];

module.exports = test(cases);
