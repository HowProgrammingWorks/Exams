'use strict';

const assert = require('node:assert/strict');
const cases = require('./cases.json');

const ERR_INPUT_MODIFIED = 'The input data should not be modified';
const ERR_FUNCTION_NOT_IMPORTED = 'The function is expected';

const capitalize = (str) => str.charAt(0).toUpperCase() + str.slice(1);

module.exports = (taskName, taskPath) => {
  const taskCases = cases[taskName];
  if (!taskCases) {
    throw new Error(`No test cases found for ${taskName}`);
  }

  const task = require(taskPath);

  assert.equal(typeof task, 'function', ERR_FUNCTION_NOT_IMPORTED);

  for (const taskCase of taskCases) {
    const cachedInput = JSON.parse(JSON.stringify(taskCase.input));
    assert.deepStrictEqual(task(...taskCase.input), taskCase.expected);
    assert.deepStrictEqual(cachedInput, taskCase.input, ERR_INPUT_MODIFIED);
  }

  console.log(`[${capitalize(taskName)}] Tests passed successfully`);
};
