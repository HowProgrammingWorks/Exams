// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const getDayNumber = function(text) {
  const dayName = text !== null ? text.toLowerCase() : '';
  for (let i = 0; i < days.length; i++) {
    const dayPrefix = days[i].toLowerCase();
    if (dayName.startsWith(dayPrefix)) {
      return i + 1;
    }
  }
};

const result = getDayNumber('friday');
console.log(result);
