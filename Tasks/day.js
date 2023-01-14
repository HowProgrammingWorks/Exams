// Get day number
'use strict'
const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (day) => {

  for (let i = 0; i < days.length; i++) {
    if (day.startsWith(days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
