'use strict';

const test = require('../test.js');

const cases = [
  [['All you need is JavaScript', 'is'], ['All you need ', ' JavaScript']],
  [['All you need is JavaScript', ' is '], ['All you need', 'JavaScript']],
  [['All you need is JavaScript', 'abc'], ['All you need is JavaScript', '']],
  [['All you need is JavaScript', ''], ['All you need is JavaScript', '']],
  [['abc-def-ghi', '-'], ['abc', 'def-ghi']],
];

module.exports = test(cases);
