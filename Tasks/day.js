'use strict';

const DAYS = ['sun', 'mon', 'tue', 'wed', 'thu', 'fri', 'sat'];

const parseDay = day => {
  for (let i = 0; i < Days.length; i++) 
    if (day.startsWith(Days[i])) return i + 1;
  return -1;
};

require('../Tests/day.js')(parseDay);
