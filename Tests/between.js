'use strict';

const test = require('../test.js');

const cases = [
  [['Hello <username> and bye!', '<', '>'], 'username'],
];

module.exports = test(cases);
