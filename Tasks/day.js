'use strict';
// Get day number

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const getDayNum = (dayName) => {
  for (const day of days) {
    if (dayName.startsWith(day.toLowerCase())) {
      return days.indexOf(day) + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(getDayNum);
