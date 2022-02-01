'use strict';

const test = require('../test.js');

const cases = [
  [['127.0.0.1'], [127, 0, 0, 1]],
];

module.exports = test(cases);
