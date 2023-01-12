'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = (s) => {
  for (let index = 0; index < days.length; index++) {
    if (s.startsWith(days[index].toLowerCase())) {
      return ++index;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
