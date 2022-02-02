'use strict';

const test = require('../test.js');

const cases = [
  [['M A'], true],
  [['Marcus Aurelius'], true],
  [['MarcusAurelius'], false],
  [['Marcus Aurelius Antoninus'], true],
  [['marcus aurelius'], true],
  [['marcus aurelius 100'], false],
  [['marcus aurelius !'], false],
];

module.exports = test(cases);
