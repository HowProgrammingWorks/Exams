'use strict';

const test = require('../test.js');

const cases = [
  [['Hello Marcus Aureluis'], 3],
  [['Hello'], 1],
  [[''], 0],
];

module.exports = test(cases);
