// Get day number

// Step 7
// Strings must use singlequote

'use strict';

const Days = ['sun', 'mon', 'tue', 'wed', 'thu', 'fri', 'sat'];

const parseDay = (str) => {
  for (let i = 0; i < Days.length; i++) {
    if (str.startsWith(Days[i])) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
