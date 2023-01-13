'use strict';
const WEEK_DAYS = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (string) => {
  for (let i = 0; i < WEEK_DAYS.length; i++) {
    if (string.startsWith(WEEK_DAYS[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};
require('../Tests/day.js')(parseDay);
