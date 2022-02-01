'use strict';

const test = require('../test.js');

const cases = [
  [['Hello "Marcus"! Ave "Marcus"!'], 'Hello «Marcus»! Ave «Marcus»!'],
];

module.exports = test(cases);
