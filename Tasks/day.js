// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const getDayNumber = (day) => {
  const end = -1;
  for (let i = 0; i < days.length; i++) {
    if (day.startsWith(days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return end;
};

require('../Tests/day.js')(getDayNumber);
