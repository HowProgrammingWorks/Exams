'use strict';

const test = require('../test.js');

const cases = [
  [[[5, true, 'string', 7, 'hello']], 12],
  [[[5, true, 'string', -7, 'hello']], -2],
  [[[0, true, 'string', 0, 'hello']], 0],
  [[[1, true, 'string', -1, 'hello']], 0],
  [[[5]], 5],
  [[[-1]], -1],
  [[[]], 0],
];

module.exports = test(cases);
