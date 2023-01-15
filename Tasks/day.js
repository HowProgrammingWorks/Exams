// Get day number
'use strict';
const DAYS = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat',];

const parseDay = (day) => {
  for (let i = 0; i < DAYS.length; i++) {
    if (day.startsWith(DAYS[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
