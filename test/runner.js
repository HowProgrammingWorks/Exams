'use strict';

const path = require('node:path');
const { spawn } = require('node:child_process');
const taskTest = require('./task.test');

const lintCode = (taskName, taskPath) => {
  const childOptions = { shell: true, stdio: 'inherit' };
  const eslintProcess = spawn('npx', ['eslint', taskPath], childOptions);

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
  const taskPath = path.join(__dirname, '../Tasks', `${taskName}.js`);
  const eslintProcess = lintCode(taskName, taskPath);
  eslintProcess.on('close', () => taskTest(taskName, taskPath));
}
