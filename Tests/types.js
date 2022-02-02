'use strict';

const test = require('../test.js');

const cases = [
  [
    [[5, true, 'string', 7, 'hello']],
    { number: 2, boolean: 1, string: 2 },
  ],
  [[[true, true]], { number: 0, boolean: 2, string: 0 }],
  [[[]], { number: 0, boolean: 0, string: 0 }],
  [[[100]], { number: 1, boolean: 0, string: 0 }],
];

module.exports = test(cases);
