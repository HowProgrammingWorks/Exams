'use strict';
const WEEK_DAYS = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
const parseDay = (srting) => {
  let i = 0;
  for (const day of WEEK_DAYS) {
    if (srting.startsWith(day.toLowerCase())) return i + 1;
    i++;
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
