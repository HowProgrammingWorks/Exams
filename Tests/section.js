'use strict';

const test = require('../test.js');

const cases = [
  [['All you need is JavaScript', 'is'], ['All you need ', ' JavaScript']],
  [['All you need is JavaScript', ' is '], ['All you need', 'JavaScript']],
];

module.exports = test(cases);
