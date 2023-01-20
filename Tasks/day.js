// Get day number

'use strict';

const week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (days) => {
  for (let i = 0; i < week.length; i++) {
    if (days.startsWith(week[i].toLowerCase())) {
      return ++i;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
