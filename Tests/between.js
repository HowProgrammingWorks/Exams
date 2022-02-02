'use strict';

const test = require('../test.js');

const cases = [
  [['Hello <username> and bye!', '<', '>'], 'username'],
  [['<username>', '<', '>'], 'username'],
  [['Hello username and bye!', '<', '>'], ''],
];

module.exports = test(cases);
