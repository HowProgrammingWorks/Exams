'use strict';

const test = require('../test.js');

const cases = [
  [
    [['Roma', 'Kiev', 'Beijing'], [100, 200, 300]],
    [['Roma', 100], ['Kiev', 200], ['Beijing', 300]],
  ],

  [
    [['Roma', 'Kiev'], [100, 200, 300]],
    [['Roma', 100], ['Kiev', 200]],
  ],

  [
    [['Roma', 'Kiev', 'Beijing'], [100, 200]],
    [['Roma', 100], ['Kiev', 200]],
  ],

  [
    [['Roma', 'Kiev', 'Beijing'], []], [],
  ],

  [[[], []], []],
];

module.exports = test(cases);
