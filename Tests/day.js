'use strict';

const test = require('../test.js');

const cases = [
  [['friday'], 6],
  [['Friday'], -1],
  [['Fri'], -1],
  [['monday'], 2],
  [['abc'], -1],
];

module.exports = test(cases);
