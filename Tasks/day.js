// Get day number
'use strict';

const Week = ['sun', 'mon', 'tue', 'wed', 'thu', 'fri', 'sat'];

const parseWeek = (string) => {
  for (let i = 0; i < Week.length; i++) {
    if (string.startsWith(Week[i])) return i + 1
  }
  return -1;
};

require('../Tests/day.js')(parseWeek);
