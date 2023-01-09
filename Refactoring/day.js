// Get day number

// Step 8
// rename identifiers, to improve readability

'use strict';

const daysArray = ['sun', 'mon', 'tue', 'wed', 'thu', 'fri', 'sat'];

const parseDay = (day) => {
  for (let i = 0; i < daysArray.length; i++) {
    if (day.startsWith(daysArray[i])) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
