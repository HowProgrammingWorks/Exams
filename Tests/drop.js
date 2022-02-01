'use strict';

const test = require('../test.js');

const cases = [
  [[{ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f'], { a: 'uno', c: 'tre' }],
];

module.exports = test(cases);
