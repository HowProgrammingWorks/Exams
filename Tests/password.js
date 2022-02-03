'use strict';

const test = require('../test.js');

const CHARS = 'abc123';

const cases = [
  [[CHARS, 7], (s) => s.length === 7],
  [[CHARS, 7], (s) => {
    for (const char of s) {
      if (!CHARS.includes(char)) return false;
    }
    return true;
  }],
];

module.exports = test(cases);
