'use strict';

const test = require('../test.js');

const cases = [
  [
    ['Hello <username> and bye!', '<username>', 'Marcus'],
    'Hello Marcus and bye!',
  ],
];

module.exports = test(cases);
