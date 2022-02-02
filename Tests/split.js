'use strict';

const test = require('../test.js');

const cases = [
  [[3, ['a', 'b', 'c', 'd', 'e']], [['a', 'b', 'c'], ['d', 'e']]],
  [[3, [1, 2, 3, 4]], [[1, 2, 3], [4]]],
  [[3, ['a', 'b', 'c']], [['a', 'b', 'c'], []]],
  [[3, ['a', 'b']], [['a', 'b'], []]],
  [[3, [1]], [[1], []]],
  [[3, []], [[], []]],
];

module.exports = test(cases);
