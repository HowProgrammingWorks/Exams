'use strict';

const fs = require('node:fs');
const path = require('node:path');
const { spawn } = require('node:child_process');

const lintCode = (taskName) => {
  const taskFilePath = path.join(__dirname, '../Tasks', `${taskName}.js`);

  const childOptions = { shell: true, stdio: 'inherit' };
  const eslintProcess = spawn('npx', ['eslint', taskFilePath], childOptions);

  console.log(`[Lint] Running eslint on ${taskName}`);

  eslintProcess.on('data', (data) => {
    console.log(data.toString());
  });

  eslintProcess.on('close', () => {
    console.log(`[Lint] Finished eslint on ${taskName}\n`);
  });

  return eslintProcess;
};

const cliArguments = process.argv.slice(2);
if (cliArguments.length === 0) {
  throw new Error('Please specify the name of the task you want to test');
}

for (const taskName of cliArguments) {
  const filePath = path.join(__dirname, `${taskName}.task.js`);
  if (!fs.existsSync(filePath)) {
    throw new Error(`Failed to find test file for "${taskName}"`);
  }

  const eslintProcess = lintCode(taskName);
  eslintProcess.on('close', () => require(filePath));
}
