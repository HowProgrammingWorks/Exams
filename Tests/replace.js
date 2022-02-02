'use strict';

const test = require('../test.js');

const cases = [
  [
    ['Hello <username> and bye!', '<username>', 'Marcus'],
    'Hello Marcus and bye!',
  ],
  [['Hello X and bye!', 'X', 'Marcus'], 'Hello Marcus and bye!'],
  [['X and bye!', 'X', 'Marcus'], 'Marcus and bye!'],
  [['Hello X', 'X', 'Marcus'], 'Hello Marcus'],
  [['Hello X', 'Y', 'Marcus'], 'Hello X'],
  [['Hello X', '', 'Marcus'], 'Hello X'],
  [['', 'Y', 'Marcus'], ''],
];

module.exports = test(cases);
