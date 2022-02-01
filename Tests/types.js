'use strict';

const test = require('../test.js');

const cases = [
  [
    [[5, true, 'string', 7, 'hello']],
    { number: 2, boolean: 1, string: 2 },
  ],
];

module.exports = test(cases);
