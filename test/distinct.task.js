'use strict';

const assert = require('node:assert/strict');
const distinct = require('../Tasks/distinct');

const ERR_INPUT_MODIFIED = 'The input data should not be modified';
const ERR_FUNCTION_NOT_IMPORTED = 'The function is expected';

const testCases = [
  { input: [[1, 2, 1, 3, 1, 4]], expected: [1, 2, 3, 4] },
  { input: [[4, 6, 2, 6, 2]], expected: [4, 6, 2] },
];

assert.equal(typeof distinct, 'function', ERR_FUNCTION_NOT_IMPORTED);

for (const testCase of testCases) {
  const cachedInput = JSON.parse(JSON.stringify(testCase.input));
  assert.deepStrictEqual(distinct(...testCase.input), testCase.expected);
  assert.deepStrictEqual(cachedInput, testCase.input, ERR_INPUT_MODIFIED);
}

console.log('[Distinct] Tests passed successfully');
