'use strict';

const test = require('../test.js');

const cases = [
  [['127.0.0.1'], [127, 0, 0, 1]],
  [['0.0.0.0'], [0, 0, 0, 0]],
  [['255.255.255.0'], [255, 255, 255, 0]],
  [['10.0.0.10'], [10, 0, 0, 10]],
  [['.0.0.'], undefined],
  [['127001'], undefined],
  [['127.0.0'], undefined],
  [[''], undefined],
];

module.exports = test(cases);
