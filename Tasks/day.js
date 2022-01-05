// Get day number
'use strict';

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
const getDayNumber = function(text) {
  for (let i = 0; i < days.length; i++) {
    if (text !== null && text.toLowerCase().startsWith(days[i].toLowerCase())) {
      return i + 1;
    }
  }
};

const result = getDayNumber('friday');
console.log(result);
