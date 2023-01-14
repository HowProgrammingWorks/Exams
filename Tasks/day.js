'use strict';
// Get day number

const daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const getDayNum = (dayName) => {
  for (const day of daysOfWeek) {
    if (dayName.startsWith(day.toLowerCase())) {
      return daysOfWeek.indexOf(day) + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(getDayNum);
