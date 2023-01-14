// Get day number
'use strict';

const day = [
  'Sun',
  'Mon',
  'Tue',
  'Wed',
  'Thu',
  'Fri',
  'Sat'
];

const parseDay = (currentDay) => {
  for (const sameDay of day) {
    const index = day.indexOf(sameDay);
    if (currentDay.startsWith(day[index].toLowerCase())) {
      return index + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
