'use strict';

const assert = require('assert').strict;

const COLOR_WARN = '\x1b[1;33m';
const COLOR_ERROR = '\x1b[0;31m';
const COLOR_INFO = '\x1b[1;37m';
const COLOR_NORM = '\x1b[0m';

const logger = (color) => (s) => {
  console.log(color + s + COLOR_NORM);
};

logger.warn = logger(COLOR_WARN);
logger.error = logger(COLOR_ERROR);
logger.info = logger(COLOR_INFO);

module.exports = (cases) => (fn) => {
  let passed = 0;
  for (const [x, expected] of cases) {
    const msg = `Case: ${fn.name}(${x}) ->`;
    let res;
    try {
      res = fn(x);
    } catch (err) {
      logger.error(`${msg} ${res}, exception: ${err.stack}`);
      continue;
    }
    try {
      assert.deepEqual(res, expected);
      passed++;
    } catch {
      logger.warn(`${msg} ${res}, expected: ${expected}`);
    }
  }
  logger.info(`Passed: ${passed} of ${cases.length}`);
};
