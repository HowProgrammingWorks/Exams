// Get day number
'use strict';

const days = [
  'Sun',
  'Mon',
  'Tue',
  'Wed',
  'Thu',
  'Fri',
  'Sat'
];

const parseDay = (currentDay) => {
  for (const sameDay of days) {
    const index = days.indexOf(sameDay);
    const smallLetters = sameDay.toLowerCase();
    const cutWord = currentDay.slice(0, 3);
    if (smallLetters === cutWord) {
      return index + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
