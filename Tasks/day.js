// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
const lowerCaseDays = [];

const parser = (day) => {
  for (let i = 0; i < days.length; i++) {
    lowerCaseDays[i] = days[i].toLowerCase();
    if (day.toLowerCase().startsWith(lowerCaseDays[i])) return i + 1;
  }
  return -1;
};

const result = parser('friday');
console.log(result);

