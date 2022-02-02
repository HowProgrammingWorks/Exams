'use strict';

const test = require('../test.js');

const cases = [
  [['Hello "Marcus"! Ave "Marcus"!'], 'Hello «Marcus»! Ave «Marcus»!'],
  [['"Marcus"! Ave "Marcus"!'], '«Marcus»! Ave «Marcus»!'],
  [['Hello "Marcus"! Ave "Marcus"'], 'Hello «Marcus»! Ave «Marcus»'],
  [['"Marcus" Ave!'], '«Marcus» Ave!'],
  [['Ave! "Marcus"'], 'Ave! «Marcus»'],
  [['"Marcus"'], '«Marcus»'],
  [['Marcus'], 'Marcus'],
  [['""'], '«»'],
  [[''], ''],
];

module.exports = test(cases);
