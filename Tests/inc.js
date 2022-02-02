'use strict';

const test = require('../test.js');

const cases = [
  [
    [{ a: 1, b: 2, c: 'hello', d: false }],
    { a: 2, b: 3, c: 'hello', d: false },
  ],
  [
    [{ a: 1, b: 2, c: 0, d: -1 }],
    { a: 2, b: 3, c: 1, d: 0 },
  ],
  [
    [{ a: -1, b: -2 }],
    { a: 0, b: -1 },
  ],
  [
    [{ a:  '-1', b: '-2' }],
    { a: '-1', b: '-2' },
  ],
];

module.exports = test(cases);
