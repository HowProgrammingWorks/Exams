// Get day number
'use strict';

const day = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (currentDay) => {
  let i;
  for (i = 0; i < day.length; i++) {
    if (currentDay.startsWith(day[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
