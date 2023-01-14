// Get day number
'use strict';

const Week = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseWeek = (s) => {
  for (let i = 0; i < Week.length; i++) {
    if (s.startsWith(Week[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseWeek);
