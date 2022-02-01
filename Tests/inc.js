'use strict';

const test = require('../test.js');

const cases = [
  [
    [{ a: 1, b: 2, c: 'hello', d: false }],
    { a: 2, b: 3, c: 'hello', d: false },
  ],
];

module.exports = test(cases);
