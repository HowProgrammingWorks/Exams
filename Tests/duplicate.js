'use strict';

const test = require('../test.js');

const cases = [
  [['abc', 5], ['abc', 'abc', 'abc', 'abc', 'abc']],
  [['abc', 1], ['abc']],
  [['abc', -1], []],
  [['abc', 0], []],
  [['', 0], []],
];

module.exports = test(cases);
