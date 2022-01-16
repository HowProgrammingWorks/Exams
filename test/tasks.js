'use strict';

const fs = require('node:fs');
const path = require('node:path');

const cliArguments = process.argv.slice(2);
if (cliArguments.length === 0) {
  throw new Error('Please specify the name of the task you want to test');
}

for (const taskName of cliArguments) {
  const filePath = path.join(__dirname, `${taskName}.task.js`);
  if (!fs.existsSync(filePath)) {
    throw new Error(`Failed to find test file for "${taskName}"`);
  }

  require(filePath);
}
