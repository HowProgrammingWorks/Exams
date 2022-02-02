'use strict';

const test = require('../test.js');

const cases = [
  [['january'], 1],
  [['february'], 2],
  [['feb'], 2],
  [['February'], 2],
  [['Feb'], 2],
  [['abc'], -1],
  [[''], -1],
];

module.exports = test(cases);
