// Get day number

'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const parseDay = searchDay => {
  for (let i = 0; i < days.length; i++) {
    if (searchDay.startsWith(days[i].toLowerCase())) return i + 1;
  }
  return -1;
};

const result = parseDay('friday');
console.log(result);
