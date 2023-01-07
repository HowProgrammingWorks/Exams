// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const getDayNumber = (num) => {
  for (let i = 0; i < days.length; i++) {
    if (num.startsWith(days[i].toLowerCase())) {
      return ++i;
    }
  }
  return -1;
};

require('../Tests/day.js')(getDayNumber);
