'use strict';

const assert = require('assert').strict;

module.exports = (cases) => (fn) => {
  let passed = 0;
  for (const [x, expected] of cases) {
    const msg = `Case: ${fn.name}(${x}) ->`;
    let res;
    try {
      res = fn(x);
    } catch (err) {
      console.log(`${msg} ${res}, exception: ${err.stack}`);
      continue;
    }
    try {
      assert.deepEqual(res, expected);
      passed++;
    } catch {
      console.log(`${msg} ${res}, expected: ${expected}`);
    }
  }
  console.log(`Passed: ${passed} of ${cases.length}`);
};
