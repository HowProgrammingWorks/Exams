// Get day number
'use strict';

const Week = ['sun', 'mon', 'tue', 'wed', 'thu', 'fri', 'sat'];

const parseWeek = (s) => {
  for (let i = 0; i < Week.length; i++) {
    const weekParsing = s.startsWith(Week[i]);
    if (weekParsing) return i + 1
  }
  return -1;
};

require('../Tests/day.js')(parseWeek);
