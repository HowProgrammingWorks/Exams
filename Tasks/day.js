'use strict';

let Days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

parseDay = (s) => {
  let i;
  for (i = 0; i < Days.length; i++) {
    if (s.startsWith(Days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require('../Tests/day.js')(parseDay);
